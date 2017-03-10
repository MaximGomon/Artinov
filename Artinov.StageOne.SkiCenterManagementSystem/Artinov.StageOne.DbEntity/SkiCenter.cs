using System.Collections.Generic;

namespace Artinov.StageOne.DbEntity
{
    /// <summary>
    /// Center where we can rent ski equipment
    /// </summary>
    public class SkiCenter : NameEntity
    {
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}