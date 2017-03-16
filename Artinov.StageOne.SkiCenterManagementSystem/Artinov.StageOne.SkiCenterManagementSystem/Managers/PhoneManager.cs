using System;
using System.Windows.Forms;

namespace Artinov.StageOne.SkiCenterManagementSystem.Managers
{
    public class PhoneManager : IEditeble
    {
        private readonly Guid _clientId;

        public PhoneManager(Guid clientId)
        {
            _clientId = clientId;
        }

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
            PhoneForm addChildren = new PhoneForm();
            addChildren.ShowInTaskbar = false;
            if (addChildren.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }
    }
}