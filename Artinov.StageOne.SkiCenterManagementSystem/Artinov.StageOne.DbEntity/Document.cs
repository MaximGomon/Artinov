using System.ComponentModel.DataAnnotations;

namespace Artinov.StageOne.DbEntity
{
    public class Document : NameEntity
    {
        [Required]
        [MaxLength(5)]
        public string Series { get; set; }
        [Required, MaxLength(20)]
        public string Number { get; set; }
    }
}