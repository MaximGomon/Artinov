using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class UcShowAllElements : UserControl, IFilleble
    {
        private readonly IEditeble _manager;
        private readonly CallbackRefresh _refreshCallback;


        public UcShowAllElements()
        {
            InitializeComponent();
        }

        public int MenuPanelHeight
        {
            set { this.scContent.Panel1.Size = new Size(scContent.Panel1.Size.Width, value); }
        }

        public ColumnHeaderStyle ColumnHeaderStyle
        {
            set { this.lvContent.HeaderStyle = value; }
        }

        public ListView.ListViewItemCollection Items => lvContent.Items;

        public UcShowAllElements(IEditeble manager, CallbackRefresh refreshCallback)
        {
            _manager = manager;
            _refreshCallback = refreshCallback;
            InitializeComponent();
            refreshCallback.Invoke(this);
            this.Dock = DockStyle.Fill;
        }

        public void FillControl(Dictionary<string, int> columns, string[][] elements)
        {
            lvContent.Columns.Clear();
            foreach (var columnHeader in columns)
            {
                lvContent.Columns.Add(columnHeader.Key, columnHeader.Value);
            }
            lvContent.Items.Clear();
            foreach (var element in elements)
            {
                lvContent.Items.Add(new ListViewItem(element));
            }
        }

        public void Delete()
        {
            if (lvContent.SelectedItems.Count == 0)
                return;

            if (
                MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                DialogResult.OK)
            {
                _manager.Delete(_refreshCallback, Guid.Parse(lvContent.SelectedItems[0].SubItems[0].Text), this);
            }
        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case nameof(tsbAdd):
                    _manager.Add(_refreshCallback, this);
                    break;
                case nameof(tsbEdit):
                    if (lvContent.SelectedItems.Count == 0)
                        break;
                    _manager.Edit(_refreshCallback, Guid.Parse(lvContent.SelectedItems[0].SubItems[0].Text), this);
                    break;
                case nameof(tsbRemove):
                    Delete();
                    break;
            }
        }
    }
}
