using System;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Helpers;

namespace Artinov.StageOne.SkiCenterManagementSystem.Managers
{
    public class ClientManager : IEditeble
    {
        public ClientManager()
        {
        }

        public void Delete(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            ServiceHelper.Client.DeleteClient(id);
        }

        public void Edit(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            ClientForm addClient = new ClientForm(id);
            addClient.ShowInTaskbar = false;
            if (addClient.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }

        public void Add(CallbackRefresh refresh, IFilleble control)
        {
            ClientForm addClient = new ClientForm();
            addClient.ShowInTaskbar = false;
            if (addClient.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }
    }
}