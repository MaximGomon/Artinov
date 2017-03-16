using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Helpers;
using Artinov.StageOne.SkiCenterManagementSystem.Managers;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class ManagementForm : Form
    {
        private UcShowAllElements _showAll;
        public ManagementForm()
        {
            InitializeComponent();
            tabControl_SelectedIndexChanged(tabControl, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
#if Release
            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.Cancel)
            {
                Close();
            }
            var centre = login.GetSelected;
            statusLabel.Text = $"You are logged into {centre.Name} center";
#endif
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedTab.Name)
            {
                case nameof(tabClients):
                    var manager = new ClientManager();
                    _showAll = new UcShowAllElements(manager, LoadClients);
                    tabClients.Controls.Add(_showAll);
                    break;
                case nameof(tabOrders):
                    _showAll = new UcShowAllElements(new OrderManager(), LoadOrders);
                    tabOrders.Controls.Add(_showAll);
                    break;
            }
        }

        private void LoadClients(IFilleble currentControl)
        {
            var clients = ServiceHelper.Client.GetClients();
            Dictionary<string, int> columns = new Dictionary<string, int> { { "Id", 1 }, { "Name", 150 }, { "Sex", 50 }, { "Age", 40 } };
            var items = clients?.Select(x => new[] { x.Id.ToString(), x.Name, x.Sex.ToString(), x.Age.ToString() }).ToArray();
            currentControl.FillControl(columns, items);
        }

        private void LoadOrders(IFilleble currentControl)
        {
            var orders = ServiceHelper.Client.GetOrders(1000, 0);
            Dictionary<string, int> columns = new Dictionary<string, int> { { "Id", 1 }, { "Number", 150 }, { "Client Name", 50 }, { "Cost", 40 } };
            var items = orders?.Select(x => new[] { x.Id.ToString(), x.Number, x.Client.Name, x.Cost.ToString() }).ToArray();
            currentControl.FillControl(columns, items);
        }
    }
}
