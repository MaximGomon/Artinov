using System.ComponentModel.DataAnnotations;

namespace Artinov.StageOne.DbEntity
{
    public abstract class NameEntity : IdEntity
    {
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
    }
}