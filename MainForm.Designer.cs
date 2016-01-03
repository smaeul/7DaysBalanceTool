namespace _7DaysBalanceTool
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            this.blocks = new _7DaysBalanceTool.blocks();
            this.blockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuOpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuExportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuGroupsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItemsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuMaterialsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuRecipesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockListLabel = new System.Windows.Forms.Label();
            this.blockList = new System.Windows.Forms.DataGridView();
            this.blockListIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockListNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertiesLabel = new System.Windows.Forms.Label();
            this.propertiesList = new System.Windows.Forms.ListBox();
            this.actionsGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.blocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockBindingSource)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockList)).BeginInit();
            this.SuspendLayout();
            // 
            // blocks
            // 
            this.blocks.DataSetName = "blocks";
            this.blocks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blockBindingSource
            // 
            this.blockBindingSource.DataMember = "block";
            this.blockBindingSource.DataSource = this.blocks;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(880, 24);
            this.mainMenu.TabIndex = 3;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuOpenItem,
            this.fileMenuSaveItem,
            this.fileMenuSeparator1,
            this.fileMenuExportItem,
            this.fileMenuSeparator2,
            this.fileMenuExitItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // fileMenuOpenItem
            // 
            this.fileMenuOpenItem.Name = "fileMenuOpenItem";
            this.fileMenuOpenItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileMenuOpenItem.Size = new System.Drawing.Size(146, 22);
            this.fileMenuOpenItem.Text = "&Open";
            this.fileMenuOpenItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // fileMenuSaveItem
            // 
            this.fileMenuSaveItem.Name = "fileMenuSaveItem";
            this.fileMenuSaveItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileMenuSaveItem.Size = new System.Drawing.Size(146, 22);
            this.fileMenuSaveItem.Text = "&Save";
            this.fileMenuSaveItem.Click += new System.EventHandler(this.saveFileMenuItem_Click);
            // 
            // fileMenuSeparator1
            // 
            this.fileMenuSeparator1.Name = "fileMenuSeparator1";
            this.fileMenuSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // fileMenuExportItem
            // 
            this.fileMenuExportItem.Name = "fileMenuExportItem";
            this.fileMenuExportItem.Size = new System.Drawing.Size(146, 22);
            this.fileMenuExportItem.Text = "&Export";
            this.fileMenuExportItem.Click += new System.EventHandler(this.exportFileMenuItem_Click);
            // 
            // fileMenuSeparator2
            // 
            this.fileMenuSeparator2.Name = "fileMenuSeparator2";
            this.fileMenuSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // fileMenuExitItem
            // 
            this.fileMenuExitItem.Name = "fileMenuExitItem";
            this.fileMenuExitItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.fileMenuExitItem.Size = new System.Drawing.Size(146, 22);
            this.fileMenuExitItem.Text = "E&xit";
            this.fileMenuExitItem.Click += new System.EventHandler(this.exitFileMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuGroupsItem,
            this.editMenuItemsItem,
            this.editMenuMaterialsItem,
            this.editMenuRecipesItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "&Edit";
            // 
            // editMenuGroupsItem
            // 
            this.editMenuGroupsItem.Name = "editMenuGroupsItem";
            this.editMenuGroupsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.editMenuGroupsItem.Size = new System.Drawing.Size(163, 22);
            this.editMenuGroupsItem.Text = "&Groups";
            // 
            // editMenuItemsItem
            // 
            this.editMenuItemsItem.Name = "editMenuItemsItem";
            this.editMenuItemsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.editMenuItemsItem.Size = new System.Drawing.Size(163, 22);
            this.editMenuItemsItem.Text = "&Items";
            // 
            // editMenuMaterialsItem
            // 
            this.editMenuMaterialsItem.Name = "editMenuMaterialsItem";
            this.editMenuMaterialsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.editMenuMaterialsItem.Size = new System.Drawing.Size(163, 22);
            this.editMenuMaterialsItem.Text = "&Materials";
            // 
            // editMenuRecipesItem
            // 
            this.editMenuRecipesItem.Name = "editMenuRecipesItem";
            this.editMenuRecipesItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.editMenuRecipesItem.Size = new System.Drawing.Size(163, 22);
            this.editMenuRecipesItem.Text = "&Recipes";
            // 
            // blockListLabel
            // 
            this.blockListLabel.Location = new System.Drawing.Point(4, 27);
            this.blockListLabel.Name = "blockListLabel";
            this.blockListLabel.Size = new System.Drawing.Size(100, 23);
            this.blockListLabel.TabIndex = 2;
            this.blockListLabel.Text = "Blocks";
            // 
            // blockList
            // 
            this.blockList.AllowUserToAddRows = false;
            this.blockList.AllowUserToDeleteRows = false;
            this.blockList.AllowUserToResizeColumns = false;
            this.blockList.AllowUserToResizeRows = false;
            this.blockList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.blockList.AutoGenerateColumns = false;
            this.blockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.blockList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blockList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.blockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.blockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blockListIdColumn,
            this.blockListNameColumn});
            this.blockList.DataSource = this.blockBindingSource;
            this.blockList.GridColor = System.Drawing.Color.LightGray;
            this.blockList.Location = new System.Drawing.Point(4, 43);
            this.blockList.MultiSelect = false;
            this.blockList.Name = "blockList";
            this.blockList.RowHeadersVisible = false;
            this.blockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.blockList.Size = new System.Drawing.Size(312, 509);
            this.blockList.StandardTab = true;
            this.blockList.TabIndex = 1;
            this.blockList.SelectionChanged += new System.EventHandler(this.blockDataGrid_Select);
            // 
            // blockListIdColumn
            // 
            this.blockListIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.blockListIdColumn.DataPropertyName = "id";
            this.blockListIdColumn.HeaderText = "ID";
            this.blockListIdColumn.MinimumWidth = 45;
            this.blockListIdColumn.Name = "blockListIdColumn";
            this.blockListIdColumn.ReadOnly = true;
            this.blockListIdColumn.Width = 45;
            // 
            // blockListNameColumn
            // 
            this.blockListNameColumn.DataPropertyName = "name";
            this.blockListNameColumn.HeaderText = "Name";
            this.blockListNameColumn.Name = "blockListNameColumn";
            this.blockListNameColumn.ReadOnly = true;
            // 
            // propertiesLabel
            // 
            this.propertiesLabel.Location = new System.Drawing.Point(320, 27);
            this.propertiesLabel.Name = "propertiesLabel";
            this.propertiesLabel.Size = new System.Drawing.Size(100, 23);
            this.propertiesLabel.TabIndex = 5;
            this.propertiesLabel.Text = "Properties";
            // 
            // propertiesList
            // 
            this.propertiesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesList.IntegralHeight = false;
            this.propertiesList.Location = new System.Drawing.Point(320, 43);
            this.propertiesList.Name = "propertiesList";
            this.propertiesList.Size = new System.Drawing.Size(300, 509);
            this.propertiesList.TabIndex = 4;
            // 
            // actionsGroup
            // 
            this.actionsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsGroup.Location = new System.Drawing.Point(624, 27);
            this.actionsGroup.Name = "actionsGroup";
            this.actionsGroup.Size = new System.Drawing.Size(252, 525);
            this.actionsGroup.TabIndex = 0;
            this.actionsGroup.TabStop = false;
            this.actionsGroup.Text = "Actions";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 556);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.blockList);
            this.Controls.Add(this.blockListLabel);
            this.Controls.Add(this.propertiesList);
            this.Controls.Add(this.propertiesLabel);
            this.Controls.Add(this.actionsGroup);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(896, 595);
            this.Name = "MainForm";
            this.Text = "Balance Tool";
            ((System.ComponentModel.ISupportInitialize)(this.blocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockBindingSource)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private blocks blocks;
        private System.Windows.Forms.BindingSource blockBindingSource;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuOpenItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenuSaveItem;
        private System.Windows.Forms.ToolStripSeparator fileMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuExportItem;
        private System.Windows.Forms.ToolStripSeparator fileMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileMenuExitItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenuGroupsItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemsItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuMaterialsItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuRecipesItem;
        private System.Windows.Forms.Label blockListLabel;
        private System.Windows.Forms.DataGridView blockList;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockListIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockListNameColumn;
        private System.Windows.Forms.Label propertiesLabel;
        private System.Windows.Forms.ListBox propertiesList;
        private System.Windows.Forms.GroupBox actionsGroup;
    }
}

