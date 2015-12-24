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

namespace _7DaysBalanceTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
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
                blockData.Clear();
                blockData.ReadXml(open.FileName);
            }
        }

        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML files (*.xml)|*.xml";

            if (save.ShowDialog() == DialogResult.OK) {
                blockData.WriteXml(save.FileName);
            }
        }
    }
}
