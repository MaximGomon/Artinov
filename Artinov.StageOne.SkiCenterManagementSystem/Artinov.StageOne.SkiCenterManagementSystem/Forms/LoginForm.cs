using System;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.SkiServiceReference;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public SkiServiceReference.SkiCenter GetSelected => (SkiServiceReference.SkiCenter)cbSkiCentres.SelectedItem;

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            using (var client = new SkiServiceClient())
            {
                if (client.CheckUser(tbLogin.Text.Trim(), tbPassword.Text.Trim()))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    errorLabel.Text = "Invalid login or password!";
                }
            }
            this.Enabled = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (var client = new SkiServiceClient())
            {
                SkiServiceReference.SkiCenter[] centers = client.GetCenters();
                cbSkiCentres.Items.AddRange(centers);
                if (cbSkiCentres.Items.Count > 0)
                    cbSkiCentres.SelectedIndex = 0;
            }
        }
    }
}

namespace Artinov.StageOne.SkiCenterManagementSystem.SkiServiceReference
{
    public partial class SkiCenter
    {
        public override string ToString()
        {
            return Name;
        }
    }

}

