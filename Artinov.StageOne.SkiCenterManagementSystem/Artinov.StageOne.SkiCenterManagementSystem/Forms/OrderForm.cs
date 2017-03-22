using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Helpers;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class OrderForm : Form
    {
        private readonly Guid _orderId;
        public OrderForm()
        {
            _orderId = Guid.NewGuid();
            InitializeComponent();
        }

        public OrderForm(Guid orderId)
        {
            _orderId = orderId;
            InitializeComponent();
        }
        
        private void cbClient_TextChanged(object sender, EventArgs e)
        {
            if (cbClient.Text.Length >= 3)
            {
                var items = ServiceHelper.Client.GetClientLikeName(cbClient.Text);

                List <ForComboBoxDisplay> itemForDisplay = new List<ForComboBoxDisplay>();
                foreach (var item in items)
                {
                    itemForDisplay.Add(new ForComboBoxDisplay
                    {
                        DisplayText = item.GetClientForDisplay(),
                        Id = item.Id
                    });
                }
                HandleTextChanged(itemForDisplay);
            }
        }

        private void HandleTextChanged(List<ForComboBoxDisplay> dataSource)
        {
            var text = cbClient.Text;

            if (dataSource.Any())
            {
                cbClient.DataSource = dataSource;
                cbClient.DroppedDown = true;
                cbClient.SelectionStart = cbClient.Text.Length;
            }
            else
            {
                cbClient.DroppedDown = false;
                cbClient.SelectionStart = text.Length;
            }
        }

        public void RefreshEquipments(IFilleble currentControl)
        {
            //var documents = ServiceHelper.Client.Get(_clientId);
            //Dictionary<string, int> columns = new Dictionary<string, int> { { "Id", 1 }, { "Name", 150 }, { "Number", 100 }, { "Series", 50 } };
            //var items = documents?.Select(x => new[] { x.Id.ToString(), x.Name, x.Number, x.Series }).ToArray() ?? new string[0][];
            //currentControl.FillControl(columns, items);
        }
    }
}
