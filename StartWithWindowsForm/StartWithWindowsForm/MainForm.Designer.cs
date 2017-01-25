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
            this.btExit = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(373, 81);
            this.btExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(175, 46);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Exit";
            this.mainToolTip.SetToolTip(this.btExit, "Press this button to close application");
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(39, 39);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 29);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(123, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(425, 34);
            this.tbName.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.tbName, "Write your name here");
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // mainToolTip
            // 
            this.mainToolTip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainToolTip.ForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // btShow
            // 
            this.btShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btShow.Location = new System.Drawing.Point(188, 81);
            this.btShow.Margin = new System.Windows.Forms.Padding(5);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(175, 46);
            this.btShow.TabIndex = 3;
            this.btShow.Text = "Show name";
            this.mainToolTip.SetToolTip(this.btShow, "Press this button to show name");
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 167);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My first form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Button btShow;
    }
}

