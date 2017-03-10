using System.Collections.Generic;

namespace Artinov.StageOne.DbEntity
{
    public class Warehouse : NameEntity
    {
         public virtual ICollection<WarehouseElement> Equipments { get; set; } 
    }
}