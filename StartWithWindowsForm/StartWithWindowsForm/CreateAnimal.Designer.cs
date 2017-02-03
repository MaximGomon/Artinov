namespace StartWithWindowsForm
{
    partial class CreateAnimal
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
                _context.Dispose();
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.gbAnimalInfo = new System.Windows.Forms.GroupBox();
            this.gbAnimalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(126, 61);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(198, 34);
            this.tbName.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(184, 210);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(167, 34);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(11, 210);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(167, 34);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(40, 64);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 29);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(58, 121);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(60, 29);
            this.lbSize.TabIndex = 4;
            this.lbSize.Text = "Size";
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(126, 118);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(198, 37);
            this.cbSize.TabIndex = 5;
            // 
            // gbAnimalInfo
            // 
            this.gbAnimalInfo.Controls.Add(this.tbName);
            this.gbAnimalInfo.Controls.Add(this.cbSize);
            this.gbAnimalInfo.Controls.Add(this.lbName);
            this.gbAnimalInfo.Controls.Add(this.lbSize);
            this.gbAnimalInfo.Location = new System.Drawing.Point(12, 12);
            this.gbAnimalInfo.Name = "gbAnimalInfo";
            this.gbAnimalInfo.Size = new System.Drawing.Size(339, 192);
            this.gbAnimalInfo.TabIndex = 6;
            this.gbAnimalInfo.TabStop = false;
            this.gbAnimalInfo.Text = "Animal info";
            // 
            // CreateAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 253);
            this.ControlBox = false;
            this.Controls.Add(this.gbAnimalInfo);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateAnimal";
            this.ShowInTaskbar = false;
            this.Text = "Add/Edit animal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAnimal_FormClosing);
            this.gbAnimalInfo.ResumeLayout(false);
            this.gbAnimalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.GroupBox gbAnimalInfo;
    }
}