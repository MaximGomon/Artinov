using Artinov.StageOne.SkiCenterManagementSystem.Managers;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    partial class OrderForm
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.gbEquipment = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.ucEqiupment = new Artinov.StageOne.SkiCenterManagementSystem.UcShowAllElements(new EquipmentManager(), RefreshEquipments);
            this.gbEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "#";
            // 
            // tbNumber
            // 
            this.tbNumber.Enabled = false;
            this.tbNumber.Location = new System.Drawing.Point(32, 12);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreateDate.Location = new System.Drawing.Point(187, 11);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.ShowUpDown = true;
            this.dtpCreateDate.Size = new System.Drawing.Size(84, 20);
            this.dtpCreateDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client";
            // 
            // cbClient
            // 
            this.cbClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(52, 53);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(335, 21);
            this.cbClient.TabIndex = 5;
            this.cbClient.TextChanged += new System.EventHandler(this.cbClient_TextChanged);
            // 
            // gbEquipment
            // 
            this.gbEquipment.Controls.Add(this.ucEqiupment);
            this.gbEquipment.Location = new System.Drawing.Point(15, 83);
            this.gbEquipment.Name = "gbEquipment";
            this.gbEquipment.Size = new System.Drawing.Size(372, 171);
            this.gbEquipment.TabIndex = 6;
            this.gbEquipment.TabStop = false;
            this.gbEquipment.Text = "Equipment";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotal.Location = new System.Drawing.Point(278, 257);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 17);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "Total";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(228, 280);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 8;
            this.btOk.Text = "Save";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(309, 280);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // ucEqiupment
            // 
            this.ucEqiupment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEqiupment.Location = new System.Drawing.Point(3, 16);
            this.ucEqiupment.Margin = new System.Windows.Forms.Padding(2);
            this.ucEqiupment.Name = "ucEqiupment";
            this.ucEqiupment.Size = new System.Drawing.Size(366, 152);
            this.ucEqiupment.TabIndex = 0;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 315);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.gbEquipment);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.gbEquipment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.GroupBox gbEquipment;
        private UcShowAllElements ucEqiupment;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}