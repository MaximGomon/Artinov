using System.ComponentModel.DataAnnotations;
using Artinov.StageOne.DbEntity.Enums;

namespace Artinov.StageOne.DbEntity
{
    public class WarehouseElement : IdEntity
    {
        [Required]
        public virtual Equipment Equipment { get; set; }
        [Required]
        public int Count { get; set; }

        [Required]
        public RentTime RentTime { get; set; }
    }
}