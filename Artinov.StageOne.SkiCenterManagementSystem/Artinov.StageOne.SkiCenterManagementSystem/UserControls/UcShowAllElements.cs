using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Helpers;
using Artinov.StageOne.SkiCenterManagementSystem.SkiServiceReference;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class UcShowAllElements : UserControl, IEditeble
    {
        private readonly Type _contentType;
        private readonly Delegate _refreshCallback;

        public UcShowAllElements(Type contentType, CallbackRefresh refreshCallback)
        {
            _contentType = contentType;
            _refreshCallback = refreshCallback;
            InitializeComponent();
        }

        public void FillControl(Dictionary<string, int> columns, string[][] elements)
        {
            foreach (var columnHeader in columns)
            {
                lvContent.Columns.Add(columnHeader.Key, columnHeader.Value);
            }
            foreach (var element in elements)
            {
                lvContent.Items.Add(new ListViewItem(element));
            }
        }

        public void Delete()
        {
            if (
                MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                DialogResult.OK)
            {
                //ServiceHelper.Client.
            }
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            Form addForm = null;
            if (_contentType == typeof (Client))
            {
                addForm = new ClientForm();
            }
            else if (_contentType == typeof (Order))
            {
                addForm = new OrderForm();
            }
            else if (_contentType == typeof(Warehouse))
            {
                addForm = new WarehouseForm();
            }
            else if (_contentType == typeof (WarehouseElement))
            {
                addForm = new EquipmentForm();
            }
            else
                return;

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _refreshCallback.DynamicInvoke(this);
            }
        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case nameof(tsbAdd):
                    Add();
                    break;
                case nameof(tsbEdit):
                    Edit();
                    break;
                case nameof(tsbRemove):
                    Delete();
                    break;
            }
        }
    }
}
