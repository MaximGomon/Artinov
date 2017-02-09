namespace StartWithWindowsForm
{
    partial class UcEditAnimal
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.gbAnimalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnimalInfo
            // 
            this.gbAnimalInfo.Controls.Add(this.tbName);
            this.gbAnimalInfo.Controls.Add(this.cbSize);
            this.gbAnimalInfo.Controls.Add(this.lbName);
            this.gbAnimalInfo.Controls.Add(this.lbSize);
            this.gbAnimalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnimalInfo.Location = new System.Drawing.Point(0, 0);
            this.gbAnimalInfo.Name = "gbAnimalInfo";
            this.gbAnimalInfo.Size = new System.Drawing.Size(357, 103);
            this.gbAnimalInfo.TabIndex = 8;
            this.gbAnimalInfo.TabStop = false;
            this.gbAnimalInfo.Text = "Animal info";
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
            this.lbName.Location = new System.Drawing.Point(48, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(58, 56);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(35, 17);
            this.lbSize.TabIndex = 4;
            this.lbSize.Text = "Size";
            // 
            // UcEditAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAnimalInfo);
            this.Name = "UcEditAnimal";
            this.Size = new System.Drawing.Size(357, 103);
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
    }
}
