using System;
using System.Collections.Generic;
using System.Linq;
using Artinov.StageOne.DataAccess;
using Artinov.StageOne.DbEntity;
using Artinov.StageOne.DbEntity.Enums;

namespace Artinov.StageOne.Logic
{
    public class OrderBusinessLogic : BaseBusinessLogic<Order, OrderRepository>
    {
        public void CreateDraftOrder(Guid orderId, Client client)
        {
            var userLogic = new BaseBusinessLogic<User, BaseRepository<User>>();
            var defaultUser = userLogic.Get(x => x.Login == "Admin").First();
            Repository.Add(new Order
            {
                Id = orderId,
                Client = client,
                IsDeleted = true,
                CreateDate = DateTime.Now,
                State = OrderState.Draft,
                Author = defaultUser,
                Number = "defaultNumber",
                Cost = 0.0
            });
        }
    }
}