using System.ComponentModel.DataAnnotations;
using Artinov.StageOne.DbEntity.Enums;

namespace Artinov.StageOne.DbEntity
{
    public class User : NameEntity
    {
        [Required]
        [MinLength(3), MaxLength(20)]
        public string Login { get; set; }
        [Required]
        [MinLength(5), MaxLength(100)]
        public string Password { get; set; }
        [Required]
        public Roles Role { get; set; }
    }
}