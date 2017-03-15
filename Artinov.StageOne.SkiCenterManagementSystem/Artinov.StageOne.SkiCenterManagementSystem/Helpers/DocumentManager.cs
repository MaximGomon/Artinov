using System;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Forms;

namespace Artinov.StageOne.SkiCenterManagementSystem.Helpers
{
    public class DocumentManager : IEditeble
    {
        public void Delete(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            //ServiceHelper.Client.
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