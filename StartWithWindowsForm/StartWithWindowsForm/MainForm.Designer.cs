namespace StartWithWindowsForm
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
            this.components = new System.ComponentModel.Container();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importFromcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expotrTocsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteByFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.colNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolTip
            // 
            this.mainToolTip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainToolTip.ForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.deleteByFormToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(458, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAnimalToolStripMenuItem,
            this.deleteAnimalToolStripMenuItem,
            this.editAnimalToolStripMenuItem,
            this.toolStripSeparator1,
            this.importFromcsvToolStripMenuItem,
            this.expotrTocsvToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createAnimalToolStripMenuItem
            // 
            this.createAnimalToolStripMenuItem.Name = "createAnimalToolStripMenuItem";
            this.createAnimalToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.createAnimalToolStripMenuItem.Text = "Create animal";
            this.createAnimalToolStripMenuItem.Click += new System.EventHandler(this.createAnimalToolStripMenuItem_Click);
            // 
            // deleteAnimalToolStripMenuItem
            // 
            this.deleteAnimalToolStripMenuItem.Name = "deleteAnimalToolStripMenuItem";
            this.deleteAnimalToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteAnimalToolStripMenuItem.Text = "Delete animal";
            this.deleteAnimalToolStripMenuItem.Click += new System.EventHandler(this.deleteAnimalToolStripMenuItem_Click);
            // 
            // editAnimalToolStripMenuItem
            // 
            this.editAnimalToolStripMenuItem.Name = "editAnimalToolStripMenuItem";
            this.editAnimalToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.editAnimalToolStripMenuItem.Text = "Edit animal";
            this.editAnimalToolStripMenuItem.Click += new System.EventHandler(this.editAnimalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // importFromcsvToolStripMenuItem
            // 
            this.importFromcsvToolStripMenuItem.Name = "importFromcsvToolStripMenuItem";
            this.importFromcsvToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.importFromcsvToolStripMenuItem.Text = "Import from *.csv";
            this.importFromcsvToolStripMenuItem.Click += new System.EventHandler(this.importFromcsvToolStripMenuItem_Click);
            // 
            // expotrTocsvToolStripMenuItem
            // 
            this.expotrTocsvToolStripMenuItem.Name = "expotrTocsvToolStripMenuItem";
            this.expotrTocsvToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.expotrTocsvToolStripMenuItem.Text = "Expotr to *.csv";
            this.expotrTocsvToolStripMenuItem.Click += new System.EventHandler(this.expotrTocsvToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // deleteByFormToolStripMenuItem
            // 
            this.deleteByFormToolStripMenuItem.Name = "deleteByFormToolStripMenuItem";
            this.deleteByFormToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.deleteByFormToolStripMenuItem.Text = "Delete By Form";
            this.deleteByFormToolStripMenuItem.Click += new System.EventHandler(this.deleteByFormToolStripMenuItem_Click);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 24);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.lvAnimals);
            this.scMain.Size = new System.Drawing.Size(458, 305);
            this.scMain.SplitterDistance = 31;
            this.scMain.TabIndex = 5;
            // 
            // lvAnimals
            // 
            this.lvAnimals.AllowColumnReorder = true;
            this.lvAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumberHeader,
            this.colNameHeader,
            this.colSizeHeader});
            this.lvAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAnimals.FullRowSelect = true;
            this.lvAnimals.GridLines = true;
            this.lvAnimals.Location = new System.Drawing.Point(0, 0);
            this.lvAnimals.MultiSelect = false;
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(458, 270);
            this.lvAnimals.TabIndex = 0;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            // 
            // colNumberHeader
            // 
            this.colNumberHeader.Text = "#";
            this.colNumberHeader.Width = 50;
            // 
            // colNameHeader
            // 
            this.colNameHeader.Text = "Name";
            this.colNameHeader.Width = 300;
            // 
            // colSizeHeader
            // 
            this.colSizeHeader.Text = "Size";
            this.colSizeHeader.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 329);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animals";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importFromcsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expotrTocsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ListView lvAnimals;
        private System.Windows.Forms.ColumnHeader colNumberHeader;
        private System.Windows.Forms.ColumnHeader colNameHeader;
        private System.Windows.Forms.ColumnHeader colSizeHeader;
        private System.Windows.Forms.ToolStripMenuItem deleteByFormToolStripMenuItem;
    }
}

