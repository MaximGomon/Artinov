using System.Collections.Generic;

namespace Artinov.StageOne.DbEntity
{
    /// <summary>
    /// Center where we can rent ski equipment
    /// </summary>
    public class SkiCenter : NameEntity
    {
        public SkiCenter()
        {
            Warehouses = new List<Warehouse>();
            Orders = new List<Order>();
        }

        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<Order> Orders { get; set; } 
    }
}