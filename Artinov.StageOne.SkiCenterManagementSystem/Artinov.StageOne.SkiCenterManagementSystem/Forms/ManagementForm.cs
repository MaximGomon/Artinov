using System;
using System.Windows.Forms;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.Cancel)
            {
                Close();
            }
            var centre = login.GetSelected;
            statusLabel.Text = $"You are logged into {centre.Name} center";
        }
    }
}
