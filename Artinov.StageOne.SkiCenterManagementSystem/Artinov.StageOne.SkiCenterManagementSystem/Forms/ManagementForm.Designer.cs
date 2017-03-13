namespace Artinov.StageOne.SkiCenterManagementSystem
{
    partial class ManagementForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.tabWarehouse = new System.Windows.Forms.TabPage();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(808, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 24);
            this.scMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tabControl);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.statusStrip);
            this.scMain.Size = new System.Drawing.Size(808, 372);
            this.scMain.SplitterDistance = 344;
            this.scMain.SplitterWidth = 3;
            this.scMain.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOrders);
            this.tabControl.Controls.Add(this.tabWarehouse);
            this.tabControl.Controls.Add(this.tabClients);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(808, 344);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabOrders
            // 
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabOrders.Size = new System.Drawing.Size(800, 318);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // tabWarehouse
            // 
            this.tabWarehouse.Location = new System.Drawing.Point(4, 22);
            this.tabWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabWarehouse.Name = "tabWarehouse";
            this.tabWarehouse.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabWarehouse.Size = new System.Drawing.Size(800, 318);
            this.tabWarehouse.TabIndex = 1;
            this.tabWarehouse.Text = "Warehouse";
            this.tabWarehouse.UseVisualStyleBackColor = true;
            // 
            // tabClients
            // 
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabClients.Size = new System.Drawing.Size(800, 324);
            this.tabClients.TabIndex = 2;
            this.tabClients.Text = "Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 3);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(808, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 396);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagementForm";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabWarehouse;
        private System.Windows.Forms.TabPage tabClients;
    }
}

