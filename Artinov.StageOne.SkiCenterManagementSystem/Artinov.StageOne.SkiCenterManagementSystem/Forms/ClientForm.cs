﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Helpers;
using Artinov.StageOne.SkiCenterManagementSystem.SkiServiceReference;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class ClientForm : Form
    {
        private readonly Guid _clientId;
        public ClientForm()
        {
            _clientId = Guid.NewGuid();
            InitializeComponent();
            this.ucTelephones.ColumnHeaderStyle = ColumnHeaderStyle.None;
            cbSex.Items.AddRange(Enum.GetValues(typeof(Sex)).Cast<object>().ToArray());
            cbSex.SelectedIndex = 0;

        }

        public ClientForm(Guid id)
        {
            _clientId = id;
            InitializeComponent();
            this.ucTelephones.ColumnHeaderStyle = ColumnHeaderStyle.None;
            cbSex.Items.AddRange(Enum.GetValues(typeof(Sex)).Cast<object>().ToArray());
            cbSex.SelectedIndex = 0;

            FillForm();
        }

        private void FillForm()
        {
            var client = ServiceHelper.Client.GetDetailClientInfo(_clientId);
            tbName.Text = client.Name;
            nudAge.Value = client.Age;
            cbSex.SelectedItem = client.Sex;
            //ucDocuments = new UcShowAllElements(new DocumentManager(), RefreshDocument);
            //ucChildren = new UcShowAllElements(new ChildrenManager(), RefreshChildren);

        }

        public void RefreshDocument(IFilleble currentControl)
        {
            var documents = ServiceHelper.Client.GetDocumentsByClientId(_clientId);
            Dictionary<string, int> columns = new Dictionary<string, int> { { "Id", 1 }, { "Name", 150 }, { "Number", 100 }, { "Series", 50 } };
            var items = documents?.Select(x => new[] { x.Id.ToString(), x.Name, x.Number, x.Series}).ToArray() ?? new string[0][];
            currentControl.FillControl(columns, items);
        }

        public void RefreshPhones(IFilleble currentControl)
        {
            var client = ServiceHelper.Client.GetDetailClientInfo(_clientId);
            Dictionary<string, int> columns = new Dictionary<string, int> { { "Id", 1 }, { "Number", 277 }};
            var items = client?.Phones.Select(x => new[] { x.Id.ToString(), x.Name}).ToArray() ?? new string[0][];
            currentControl.FillControl(columns, items);
        }

        public void RefreshChildren(IFilleble currentControl)
        {
            var clients = ServiceHelper.Client.GetDetailClientInfo(_clientId);
            Dictionary<string, int> columns = new Dictionary<string, int> { { "Id", 1 }, { "Name", 200 }, { "Sex", 80 }, { "Age", 50 } };
            var items = clients?.Childs?.Select(x => new[] { x.Id.ToString(), x.Name, x.Sex.ToString(), x.Age.ToString() }).ToArray() ?? new string[0][];
            currentControl.FillControl(columns, items);
        }

        private void btOk_Click(object sender, System.EventArgs e)
        {
            this.Enabled = false;
            List<LittleClient> children = new List<LittleClient>(); 
            foreach (ListViewItem item in ucChildren.Items)
            {
                children.Add(new LittleClient
                {
                    Sex = (Sex)Enum.Parse(typeof(Sex), item.SubItems[2].Text),
                    Age = int.Parse(item.SubItems[3].Text),
                    Id = Guid.Parse(item.SubItems[0].Text),
                    Name = item.SubItems[1].Text,
                    IsDeleted = false
                });
            }

            List<Document> documents = new List<Document>();
            foreach (ListViewItem item in ucDocuments.Items)
            {
                documents.Add(new Document
                {
                    Id = Guid.Parse(item.SubItems[0].Text),
                    Name = item.SubItems[1].Text,
                    IsDeleted = false,
                    Number = item.SubItems[2].Text,
                    Series = item.SubItems[3].Text
                });
            }

            var client = new BigClient
            {
                Id = _clientId,
                Name = tbName.Text.Trim(),
                Age = (int)nudAge.Value,
                IsDeleted = false,
                Sex = (Sex)cbSex.SelectedItem,
                Childs = children.ToArray(),
                Documents = documents.ToArray(),
            };
            
            ServiceHelper.Client.AddClient(client);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
