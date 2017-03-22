namespace Artinov.StageOne.SkiCenterManagementSystem
{
    partial class SelectEquipmentForm
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.tvTypes = new System.Windows.Forms.TreeView();
            this.lvItems = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scContent);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.btCancel);
            this.scMain.Panel2.Controls.Add(this.btOk);
            this.scMain.Size = new System.Drawing.Size(537, 363);
            this.scMain.SplitterDistance = 319;
            this.scMain.SplitterWidth = 5;
            this.scMain.TabIndex = 0;
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.Location = new System.Drawing.Point(0, 0);
            this.scContent.Margin = new System.Windows.Forms.Padding(4);
            this.scContent.Name = "scContent";
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.tvTypes);
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.lvItems);
            this.scContent.Size = new System.Drawing.Size(537, 319);
            this.scContent.SplitterDistance = 178;
            this.scContent.SplitterWidth = 5;
            this.scContent.TabIndex = 0;
            // 
            // tvTypes
            // 
            this.tvTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTypes.Location = new System.Drawing.Point(0, 0);
            this.tvTypes.Margin = new System.Windows.Forms.Padding(4);
            this.tvTypes.Name = "tvTypes";
            this.tvTypes.Size = new System.Drawing.Size(178, 319);
            this.tvTypes.TabIndex = 0;
            this.tvTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTypes_AfterSelect);
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ItemName,
            this.Count});
            this.lvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.Location = new System.Drawing.Point(0, 0);
            this.lvItems.Margin = new System.Windows.Forms.Padding(4);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(354, 319);
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Width = 1;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 200;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCancel.Location = new System.Drawing.Point(257, 6);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 28);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(149, 6);
            this.btOk.Margin = new System.Windows.Forms.Padding(4);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(100, 28);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Select";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // SelectEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 363);
            this.Controls.Add(this.scMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectEquipmentForm";
            this.Text = "SelectEquipmentForm";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.TreeView tvTypes;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}