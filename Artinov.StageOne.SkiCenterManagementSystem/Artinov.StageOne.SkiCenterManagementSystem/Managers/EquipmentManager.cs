using System;
using System.Windows.Forms;

namespace Artinov.StageOne.SkiCenterManagementSystem.Managers
{
    public class EquipmentManager : IEditeble
    {
        public void Delete(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            //ServiceHelper.Client.DeleteE(id);
        }

        public void Edit(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            throw new System.NotImplementedException();
        }

        public void Add(CallbackRefresh refresh, IFilleble control)
        {
            SelectEquipmentForm addChildren = new SelectEquipmentForm();
            addChildren.ShowInTaskbar = false;
            if (addChildren.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }
    }
}