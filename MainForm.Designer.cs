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
            this.blockDataGrid = new System.Windows.Forms.DataGridView();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.materialsEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            ((System.ComponentModel.ISupportInitialize)(this.blockDataGrid)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();

            // 
            // actionsBox
            // 
            this.actionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsBox.Location = new System.Drawing.Point(637, 27);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(240, 526);
            this.actionsBox.TabIndex = 0;
            this.actionsBox.TabStop = false;
            this.actionsBox.Text = "Actions";

            // 
            // blockDataGrid
            // 
            this.blockDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blockDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blockDataGrid.Location = new System.Drawing.Point(0, 24);
            this.blockDataGrid.Name = "blockDataGrid";
            this.blockDataGrid.Size = new System.Drawing.Size(630, 536);
            this.blockDataGrid.TabIndex = 2;

            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialsEditMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";

            // 
            // exitFileMenuItem
            // 
            this.exitFileMenuItem.Name = "exitFileMenuItem";
            this.exitFileMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitFileMenuItem.Text = "E&xit";

            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.saveFileMenuItem,
            this.fileMenuSeparator,
            this.exitFileMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";

            // 
            // fileMenuSeparator
            // 
            this.fileMenuSeparator.Name = "fileMenuSeparator";
            this.fileMenuSeparator.Size = new System.Drawing.Size(149, 6);

            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(884, 24);
            this.mainMenu.TabIndex = 1;

            // 
            // materialsEditMenuItem
            // 
            this.materialsEditMenuItem.Name = "materialsEditMenuItem";
            this.materialsEditMenuItem.Size = new System.Drawing.Size(152, 22);
            this.materialsEditMenuItem.Text = "Materials";

            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileMenuItem.Text = "&Open";

            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileMenuItem.Text = "&Save";

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.blockDataGrid);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(500, 600);
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
        private System.Windows.Forms.DataGridView blockDataGrid;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripSeparator fileMenuSeparator;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem materialsEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
    }
}

