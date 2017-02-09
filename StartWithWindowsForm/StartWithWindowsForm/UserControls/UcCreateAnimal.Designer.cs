namespace StartWithWindowsForm
{
    partial class UcCreateAnimal
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
            this.gbAnimalInfo = new System.Windows.Forms.GroupBox();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.gbAnimalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnimalInfo
            // 
            this.gbAnimalInfo.Controls.Add(this.lbCreateDate);
            this.gbAnimalInfo.Controls.Add(this.dtpCreateDate);
            this.gbAnimalInfo.Controls.Add(this.tbName);
            this.gbAnimalInfo.Controls.Add(this.cbSize);
            this.gbAnimalInfo.Controls.Add(this.lbName);
            this.gbAnimalInfo.Controls.Add(this.lbSize);
            this.gbAnimalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnimalInfo.Location = new System.Drawing.Point(0, 0);
            this.gbAnimalInfo.Name = "gbAnimalInfo";
            this.gbAnimalInfo.Size = new System.Drawing.Size(349, 136);
            this.gbAnimalInfo.TabIndex = 7;
            this.gbAnimalInfo.TabStop = false;
            this.gbAnimalInfo.Text = "Animal info";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(50, 83);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(58, 17);
            this.lbCreateDate.TabIndex = 7;
            this.lbCreateDate.Text = "Created";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreateDate.Location = new System.Drawing.Point(126, 83);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(198, 22);
            this.dtpCreateDate.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(126, 23);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(198, 22);
            this.tbName.TabIndex = 0;
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(126, 53);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(198, 24);
            this.cbSize.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(63, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(73, 56);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(35, 17);
            this.lbSize.TabIndex = 4;
            this.lbSize.Text = "Size";
            // 
            // UcCreateAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAnimalInfo);
            this.Name = "UcCreateAnimal";
            this.Size = new System.Drawing.Size(349, 136);
            this.gbAnimalInfo.ResumeLayout(false);
            this.gbAnimalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnimalInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
    }
}
