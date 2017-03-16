using System;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Helpers;

namespace Artinov.StageOne.SkiCenterManagementSystem.Managers
{
    public class DocumentManager : IEditeble
    {
        private readonly Guid _clientId;

        public DocumentManager(Guid clientId)
        {
            _clientId = clientId;
        }

        public void Delete(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            ServiceHelper.Client.DeleteDocument(id);
        }

        public void Edit(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            throw new System.NotImplementedException();
        }

        public void Add(CallbackRefresh refresh, IFilleble control)
        {
            DocumentForm addDocument = new DocumentForm();
            addDocument.ShowInTaskbar = false;
            if (addDocument.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }
    }
}