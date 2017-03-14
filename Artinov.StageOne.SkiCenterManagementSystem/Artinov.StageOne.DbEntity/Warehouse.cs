using System.Collections.Generic;

namespace Artinov.StageOne.DbEntity
{
    public class Warehouse : NameEntity
    {
        public Warehouse()
        {
            Equipments = new List<WarehouseElement>();
        }
        public virtual ICollection<WarehouseElement> Equipments { get; set; }
    }
}