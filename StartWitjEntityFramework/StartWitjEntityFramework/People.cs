using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StartWithEntityFramework
{
    public class People
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(80)]
        public string LastName { get; set; }
        [Range(1, 110)]
        public int Age { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(30)]
        public string Login { get; set; }
        public virtual Profession Profession { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {FirstName} {LastName}, Profession: {Profession.Name}";
        }
    }
}