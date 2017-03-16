using System;
using System.Windows.Forms;

namespace Artinov.StageOne.SkiCenterManagementSystem.Managers
{
    public class OrderManager : IEditeble
    {
        public void Delete(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            //ServiceHelper.Client.DeleteClient(id);
        }

        public void Edit(CallbackRefresh refresh, Guid id, IFilleble control)
        {
            OrderForm addOrder = new OrderForm(id);
            addOrder.ShowInTaskbar = false;
            if (addOrder.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }

        public void Add(CallbackRefresh refresh, IFilleble control)
        {
            OrderForm addOrder = new OrderForm();
            addOrder.ShowInTaskbar = false;
            if (addOrder.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }
    }
}