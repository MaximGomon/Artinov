using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Artinov.StageOne.SkiCenterManagementSystem.Helpers
{
    public class ClientManager : IEditeble
    {
        public ClientManager()
        {
        }

        public void Delete(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            //ServiceHelper.Client.
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