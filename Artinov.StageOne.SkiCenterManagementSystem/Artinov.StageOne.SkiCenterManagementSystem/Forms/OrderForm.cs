using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Helpers;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Guid orderId)
        {
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
                cbClient.SelectionStart = text.Length;
            }
            else
            {
                cbClient.DroppedDown = false;
                cbClient.SelectionStart = text.Length;
            }
        }
    }
}
