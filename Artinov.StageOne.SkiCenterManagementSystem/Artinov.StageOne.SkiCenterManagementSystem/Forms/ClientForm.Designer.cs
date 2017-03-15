using Artinov.StageOne.SkiCenterManagementSystem.Helpers;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPhones = new System.Windows.Forms.GroupBox();
            this.ucTelephones = new UcShowAllElements(new PhoneManager(_clientId), RefreshPhones);
            this.gbDocuments = new System.Windows.Forms.GroupBox();
            this.ucDocuments = new UcShowAllElements(new DocumentManager(), RefreshDocument);
            this.cbChildren = new System.Windows.Forms.GroupBox();
            this.ucChildren = new UcShowAllElements(new ChildrenManager(), RefreshChildren);
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.gbPhones.SuspendLayout();
            this.gbDocuments.SuspendLayout();
            this.cbChildren.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(47, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 20);
            this.tbName.TabIndex = 1;
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.nudAge);
            this.gbGeneral.Controls.Add(this.label3);
            this.gbGeneral.Controls.Add(this.cbSex);
            this.gbGeneral.Controls.Add(this.label2);
            this.gbGeneral.Controls.Add(this.label1);
            this.gbGeneral.Controls.Add(this.tbName);
            this.gbGeneral.Location = new System.Drawing.Point(12, 12);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(287, 86);
            this.gbGeneral.TabIndex = 2;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General information";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(226, 46);
            this.nudAge.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(45, 20);
            this.nudAge.TabIndex = 5;
            this.nudAge.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(47, 46);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(97, 21);
            this.cbSex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sex";
            // 
            // gbPhones
            // 
            this.gbPhones.Controls.Add(this.ucTelephones);
            this.gbPhones.Location = new System.Drawing.Point(322, 12);
            this.gbPhones.Name = "gbPhones";
            this.gbPhones.Size = new System.Drawing.Size(287, 86);
            this.gbPhones.TabIndex = 3;
            this.gbPhones.TabStop = false;
            this.gbPhones.Text = "Phones";
            // 
            // ucTelephones
            // 
            this.ucTelephones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTelephones.Location = new System.Drawing.Point(3, 16);
            this.ucTelephones.Margin = new System.Windows.Forms.Padding(2);
            this.ucTelephones.Name = "ucTelephones";
            this.ucTelephones.Size = new System.Drawing.Size(281, 67);
            this.ucTelephones.TabIndex = 0;
            // 
            // gbDocuments
            // 
            this.gbDocuments.Controls.Add(this.ucDocuments);
            this.gbDocuments.Location = new System.Drawing.Point(12, 104);
            this.gbDocuments.Name = "gbDocuments";
            this.gbDocuments.Size = new System.Drawing.Size(594, 123);
            this.gbDocuments.TabIndex = 4;
            this.gbDocuments.TabStop = false;
            this.gbDocuments.Text = "Documents";
            // 
            // ucDocuments
            // 
            this.ucDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDocuments.Location = new System.Drawing.Point(3, 16);
            this.ucDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.ucDocuments.Name = "ucDocuments";
            this.ucDocuments.Size = new System.Drawing.Size(588, 104);
            this.ucDocuments.TabIndex = 0;
            // 
            // cbChildren
            // 
            this.cbChildren.Controls.Add(this.ucChildren);
            this.cbChildren.Location = new System.Drawing.Point(12, 233);
            this.cbChildren.Name = "cbChildren";
            this.cbChildren.Size = new System.Drawing.Size(591, 124);
            this.cbChildren.TabIndex = 5;
            this.cbChildren.TabStop = false;
            this.cbChildren.Text = "Children";
            // 
            // ucChildren
            // 
            this.ucChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucChildren.Location = new System.Drawing.Point(3, 16);
            this.ucChildren.Margin = new System.Windows.Forms.Padding(2);
            this.ucChildren.Name = "ucChildren";
            this.ucChildren.Size = new System.Drawing.Size(585, 105);
            this.ucChildren.TabIndex = 0;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(229, 363);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(310, 363);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 393);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbChildren);
            this.Controls.Add(this.gbDocuments);
            this.Controls.Add(this.gbPhones);
            this.Controls.Add(this.gbGeneral);
            this.Name = "ClientForm";
            this.Text = "ClientAdd";
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.gbPhones.ResumeLayout(false);
            this.gbDocuments.ResumeLayout(false);
            this.cbChildren.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPhones;
        private UcShowAllElements ucTelephones;
        private System.Windows.Forms.GroupBox gbDocuments;
        private UcShowAllElements ucDocuments;
        private System.Windows.Forms.GroupBox cbChildren;
        private UcShowAllElements ucChildren;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}