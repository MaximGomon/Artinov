using System.ComponentModel.DataAnnotations;

namespace Artinov.StageOne.DbEntity
{
    public class WarehouseElement : IdEntity
    {
        [Required]
        public virtual Equipment Equipment { get; set; }
        [Required]
        public int Count { get; set; }
    }
}