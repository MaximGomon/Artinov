using Artinov.StageOne.SkiCenterManagementSystem.SkiServiceReference;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    partial class UcShowAllElements
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcShowAllElements));
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.lvContent = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.Location = new System.Drawing.Point(0, 0);
            this.scContent.Margin = new System.Windows.Forms.Padding(2);
            this.scContent.Name = "scContent";
            this.scContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.toolStripMenu);
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.lvContent);
            this.scContent.Size = new System.Drawing.Size(670, 459);
            this.scContent.SplitterDistance = 27;
            this.scContent.SplitterWidth = 3;
            this.scContent.TabIndex = 0;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbRemove,
            this.tsbEdit});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(670, 27);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            this.toolStripMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenu_ItemClicked);
            // 
            // tsbAdd
            // 
            this.tsbAdd.AutoSize = false;
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(50, 50);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsbRemove
            // 
            this.tsbRemove.AutoSize = false;
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemove.Image")));
            this.tsbRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(50, 50);
            this.tsbRemove.Text = "Delete";
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(24, 24);
            this.tsbEdit.Text = "Edit";
            // 
            // lvContent
            // 
            this.lvContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvContent.FullRowSelect = true;
            this.lvContent.GridLines = true;
            this.lvContent.Location = new System.Drawing.Point(0, 0);
            this.lvContent.Margin = new System.Windows.Forms.Padding(2);
            this.lvContent.MultiSelect = false;
            this.lvContent.Name = "lvContent";
            this.lvContent.Size = new System.Drawing.Size(670, 429);
            this.lvContent.TabIndex = 0;
            this.lvContent.UseCompatibleStateImageBehavior = false;
            this.lvContent.View = System.Windows.Forms.View.Details;
            // 
            // UcShowAllElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcShowAllElements";
            this.Size = new System.Drawing.Size(670, 459);
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel1.PerformLayout();
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ListView lvContent;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStripButton tsbEdit;
    }
}
