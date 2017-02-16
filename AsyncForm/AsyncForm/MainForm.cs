using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btSubmit_Click(object sender, EventArgs e)
        {
            btSubmit.Enabled = false;
            try
            {
                lbResult.Text = await Task.Run(() => CheckLogin(tbLogin.Text, tbPassword.Text));
                if(lbResult.Text == "Correct")
                    lbResult.ForeColor = Color.ForestGreen;
            }
            finally
            {
                btSubmit.Enabled = true;
            }
        }

        private string CheckLogin(string login, string password)
        {
            Thread.Sleep(4000);
            string errorText = "Login/Password are invalid";
            if (password.Length < 5 || password == login
                || string.IsNullOrWhiteSpace(password)
                || string.IsNullOrWhiteSpace(login))
            {
                return errorText;
            }
            return "Correct";
        }

        private void btMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is message box");
        }
    }
}
