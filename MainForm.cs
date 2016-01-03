using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace _7DaysBalanceTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void blockDataGrid_Select(object sender, EventArgs e)
        {
            // This event fires when adding the first row to the DataSet, before any data is added. It also fires when selecting the empty row at the end used for adding new records.
            if (this.blockList.CurrentRow == null || this.blockList.CurrentRow.DataBoundItem == null) return;

            this.propertiesList.Items.Clear();
            this.propertiesList.Items.AddRange(((this.blockList.CurrentRow.DataBoundItem as DataRowView).Row.GetChildRows(this.blocks.Relations["block_property"]) as blocks.propertyRow[]).Select(prop => prop.name + " = " + prop.value).ToArray());
        }

        private void exitFileMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wiki Markup (*.txt)|*.txt";
            // Should display dialog to filter blocks, filling in the list; for now include all.
            List<UInt32> selectedBlocks = new List<UInt32>(this.blocks.block.Select(row => row.id));

            if (save.ShowDialog() == DialogResult.OK) {
                StreamWriter output = new StreamWriter(save.OpenFile());
                output.WriteLine("{| class=\"wikitable sortable\"");
                output.WriteLine("|-");
                output.WriteLine("! Name !! HP !! Hardness !! Downgrades To !! Upgrades To !! Mass !! Max Load !! Structural Integrity");
                foreach (blocks.blockRow block in this.blocks.block.Where(row => selectedBlocks.Contains(row.id))) {
                    blocks.propertyRow[] properties = block.GetChildRows(this.blocks.Relations["block_property"]) as blocks.propertyRow[];
                    output.WriteLine("|-");
                    output.Write("| " + block.name + " || Unknown || Unknown || ");
                    output.Write(properties.Where(prop => prop.name == "DowngradeBlock").SingleOrDefault()?.value);
                    output.Write(" || " + properties.Where(prop => prop.name == "UpgradeBlock.ToBlock").SingleOrDefault()?.value);
                    output.WriteLine(" || Unknown || Unknown || Unknown ");
                }
                output.WriteLine("|}");
                output.Close();
            }
        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML files (*.xml)|*.xml";

            if (open.ShowDialog() == DialogResult.OK) {
                // Flatten recursive class/name property element groups to class.name property elements.
                XDocument doc = XDocument.Load(open.FileName);
                foreach (XElement property in doc.XPathSelectElements("/blocks/block/property/property").ToList()) {
                    XElement propertyGroup = property.Parent, block = propertyGroup.Parent;
                    block.Add(new XElement("property", new XAttribute("name", propertyGroup.Attribute("class").Value + "." + property.Attribute("name").Value), property.Attribute("value")));
                    property.Remove();
                    if (!propertyGroup.HasElements) {
                        propertyGroup.Remove();
                    }
                }

                // Sort the properties by name; do it now, so both the list in the UI and the saved file are sorted.
                foreach (XElement block in doc.Root.Elements()) {
                    block.ReplaceNodes(block.Elements().OrderBy(elem => elem.Name + (elem.Name == "drop" ? elem.Attribute("event").Value : elem.Attribute("name")?.Value ?? "z" + elem.Attribute("class")?.Value)));
                }

                this.blocks.Clear();
                this.blocks.ReadXml(doc.CreateReader());
            }
        }

        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML files (*.xml)|*.xml";

            if (save.ShowDialog() == DialogResult.OK) {
                // Restore structure of recursive class/name property element groups from class.name property elements.
                XDocument doc = XDocument.Load(new StringReader(this.blocks.GetXml()));
                foreach (XElement property in doc.XPathSelectElements("/blocks/block/property[contains(@name, '.')]").Reverse().ToList()) {
                    String[] propertyNameParts = property.Attribute("name").Value.Split('.');

                    // Map.Color does not work unflattened, RepairItems does not work flattened... what to do?
                    if (propertyNameParts[0] == "Map") continue;

                    // Make sure there is a class element to attach this property element to.
                    XElement classElement = property.Parent.Elements().Where(prop => prop.Attribute("class")?.Value == propertyNameParts[0]).SingleOrDefault();
                    if (classElement == null) {
                        classElement = new XElement("property", new XAttribute("class", propertyNameParts[0]));
                        property.Parent.AddFirst(classElement);
                    }

                    // Move the property element to inside the class element.
                    property.Remove();
                    classElement.Add(property);

                    // Rename the property to just the part after the dot.
                    property.Attribute("name").Value = propertyNameParts[1];
                }

                // The game cannot handle a file starting with a BOM.
                StreamWriter stream = new StreamWriter(save.FileName, false, new UTF8Encoding(false));
                doc.Save(stream);
            }
        }
    }
}
