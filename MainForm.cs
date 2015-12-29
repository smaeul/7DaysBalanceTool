using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (this.blockDataGrid.CurrentRow == null) return;

            this.otherPropertiesBox.Items.Clear();
            foreach (DataRow row in (this.blockDataGrid.CurrentRow.DataBoundItem as DataRowView).Row.GetChildRows(this.blockData.Relations["block_property"])) {
                this.otherPropertiesBox.Items.Add(row.Field<String>("name") + " = " + row.Field<String>("value"));
            }
        }

        private void exitFileMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML files (*.xml)|*.xml";

            if (open.ShowDialog() == DialogResult.OK) {
                /* Flatten recursive class/name property element groups to class.name property elements */
                XDocument doc = XDocument.Load(open.FileName);
                foreach (XElement property in doc.XPathSelectElements("/blocks/block/property/property").ToList()) {
                    XElement propertyGroup = property.Parent, block = propertyGroup.Parent;
                    block.Add(new XElement("property", new XAttribute("name", propertyGroup.Attribute("class").Value + "." + property.Attribute("name").Value), property.Attribute("value")));
                    property.Remove();
                    if (!propertyGroup.HasElements) {
                        propertyGroup.Remove();
                    }
                }

                this.blockData.Clear();
                this.blockData.ReadXml(doc.CreateReader());
                /* Resize columns, then turn off autosizing to avoid columns changing width when sorted */
                this.blockDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.blockDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                this.blockDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
        }

        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML files (*.xml)|*.xml";

            if (save.ShowDialog() == DialogResult.OK) {
                this.blockData.WriteXml(save.FileName);
            }
        }
    }
}
