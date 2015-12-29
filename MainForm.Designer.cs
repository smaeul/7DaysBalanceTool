﻿namespace _7DaysBalanceTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actionsBox = new System.Windows.Forms.GroupBox();
            this.blockData = new System.Data.DataSet();
            this.blockDataGrid = new System.Windows.Forms.DataGridView();
            this.blockDataGridLabel = new System.Windows.Forms.Label();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemsEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.materialsEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherPropertiesBox = new System.Windows.Forms.ListBox();
            this.otherPropertiesLabel = new System.Windows.Forms.Label();
            this.propertiesBox = new System.Windows.Forms.GroupBox();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            
            ((System.ComponentModel.ISupportInitialize)(this.blockDataGrid)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();

            // 
            // actionsBox
            // 
            this.actionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.actionsBox.Location = new System.Drawing.Point(624, 27);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(252, 530);
            this.actionsBox.Text = "Actions";

            // 
            // blockData
            // 
            this.blockData.DataSetName = "blockData";
            this.blockData.ReadXmlSchema(System.Reflection.Assembly.GetAssembly(System.Type.GetType("_7DaysBalanceTool.MainForm")).GetManifestResourceStream("_7DaysBalanceTool.blocks.xsd"));

            // 
            // blockDataGrid
            // 
            this.blockDataGrid.AllowUserToAddRows = false;
            this.blockDataGrid.AllowUserToResizeColumns = false;
            this.blockDataGrid.AllowUserToResizeRows = false;
            this.blockDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            this.blockDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.blockDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            this.blockDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blockDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.blockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.blockDataGrid.DataMember = "block";
            this.blockDataGrid.DataSource = this.blockData;
            this.blockDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.blockDataGrid.Location = new System.Drawing.Point(4, 43);
            this.blockDataGrid.MultiSelect = false;
            this.blockDataGrid.Name = "blockDataGrid";
            this.blockDataGrid.ReadOnly = true;
            this.blockDataGrid.RowHeadersVisible = false;
            this.blockDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.blockDataGrid.Size = new System.Drawing.Size(312, 514);
            this.blockDataGrid.StandardTab = true;
            this.blockDataGrid.SelectionChanged += new System.EventHandler(blockDataGrid_Select);

            // 
            // blockDataGridLabel
            // 
            this.blockDataGridLabel.Location = new System.Drawing.Point(4, 27);
            this.blockDataGridLabel.Name = "blockDataGridLabel";
            this.blockDataGridLabel.Text = "Blocks";

            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.itemsEditMenuItem,
                this.materialsEditMenuItem });
            this.editMenu.Name = "editMenu";
            this.editMenu.Text = "&Edit";

            // 
            // exitFileMenuItem
            // 
            this.exitFileMenuItem.Name = "exitFileMenuItem";
            this.exitFileMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q;
            this.exitFileMenuItem.Text = "E&xit";
            this.exitFileMenuItem.Click += new System.EventHandler(this.exitFileMenuItem_Click);
            
            // 
            // exportFileMenuItem
            // 
            this.exportFileMenuItem.Name = "exportFileMenuItem";
            this.exportFileMenuItem.Text = "&Export";

            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openFileMenuItem,
                this.saveFileMenuItem, this.fileMenuSeparator1, this.exportFileMenuItem, this.fileMenuSeparator2,
                this.exitFileMenuItem });
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Text = "&File";

            // 
            // fileMenuSeparator1
            // 
            this.fileMenuSeparator1.Name = "fileMenuSeparator1";

            // 
            // fileMenuSeparator2
            // 
            this.fileMenuSeparator2.Name = "fileMenuSeparator2";

            // 
            // itemsEditMenuItem
            // 
            this.itemsEditMenuItem.Name = "itemsEditMenuItem";
            this.itemsEditMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I;
            this.itemsEditMenuItem.Text = "&Items";

            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileMenu,
                this.editMenu });
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(884, 24);

            // 
            // materialsEditMenuItem
            // 
            this.materialsEditMenuItem.Name = "materialsEditMenuItem";
            this.materialsEditMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M;
            this.materialsEditMenuItem.Text = "&Materials";

            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            this.openFileMenuItem.Text = "&Open";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);

            // 
            // otherPropertiesBox
            // 
            this.otherPropertiesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right));
            this.otherPropertiesBox.IntegralHeight = false;
            this.otherPropertiesBox.Location = new System.Drawing.Point(320, 340);
            this.otherPropertiesBox.Name = "otherPropertiesBox";
            this.otherPropertiesBox.Size = new System.Drawing.Size(300, 217);

            // 
            // otherPropertiesLabel
            // 
            this.otherPropertiesLabel.Location = new System.Drawing.Point(320, 324);
            this.otherPropertiesLabel.Name = "otherPropertiesLabel";
            this.otherPropertiesLabel.Text = "Other Properties";

            // 
            // propertiesBox
            // 
            this.propertiesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.propertiesBox.Location = new System.Drawing.Point(320, 27);
            this.propertiesBox.Name = "propertiesBox";
            this.propertiesBox.Size = new System.Drawing.Size(300, 294);
            this.propertiesBox.Text = "Common Properties";

            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            this.saveFileMenuItem.Text = "&Save";
            this.saveFileMenuItem.Click += new System.EventHandler(this.saveFileMenuItem_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.blockDataGrid);
            this.Controls.Add(this.blockDataGridLabel);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.otherPropertiesBox);
            this.Controls.Add(this.otherPropertiesLabel);
            this.Controls.Add(this.propertiesBox);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(896, 600);
            this.Name = "MainForm";
            this.Text = "Balance Tool";
            
            ((System.ComponentModel.ISupportInitialize)(this.blockDataGrid)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox actionsBox;
        private System.Data.DataSet blockData;
        private System.Windows.Forms.DataGridView blockDataGrid;
        private System.Windows.Forms.Label blockDataGridLabel;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripSeparator fileMenuSeparator1;
        private System.Windows.Forms.ToolStripSeparator fileMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemsEditMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem materialsEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ListBox otherPropertiesBox;
        private System.Windows.Forms.Label otherPropertiesLabel;
        private System.Windows.Forms.GroupBox propertiesBox;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
    }
}

