using System.ComponentModel.DataAnnotations;
using Artinov.StageOne.DbEntity.Enums;

namespace Artinov.StageOne.DbEntity
{
    public class Equipment : NameEntity
    {
        [Required]
        public virtual EquipmentSize Size { get; set; }
        [Required]
        public virtual EquipmentType Type { get; set; }
    }
}