using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Forms;

namespace Artinov.StageOne.SkiCenterManagementSystem.Helpers
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