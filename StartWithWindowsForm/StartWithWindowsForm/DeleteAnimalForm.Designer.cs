namespace StartWithWindowsForm
{
    partial class DeleteAnimalForm
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
            this.AnimalsListBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnimalsListBox
            // 
            this.AnimalsListBox.FormattingEnabled = true;
            this.AnimalsListBox.Location = new System.Drawing.Point(12, 12);
            this.AnimalsListBox.Name = "AnimalsListBox";
            this.AnimalsListBox.Size = new System.Drawing.Size(368, 303);
            this.AnimalsListBox.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(264, 328);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(116, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete Animal";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 363);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AnimalsListBox);
            this.Name = "DeleteAnimalForm";
            this.Text = "DeleteAnimalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AnimalsListBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}