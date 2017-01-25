using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StartWithEntityFramework
{
    public class Profession
    {
        [Key]
        public int Id { get; set; }
        
        [MinLength(3)]
        [MaxLength(150)]
        public string Name { get; set; }
    }
}