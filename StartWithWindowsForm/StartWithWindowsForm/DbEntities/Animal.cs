using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartWithWindowsForm
{
    public class Animal : IdEntity
    {
        public Animal()
        {
            
        }
        
        public AnimalSize Size { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
        public virtual AnimalType Type { get; set; }

        public override string ToString()
        {
            return $"{Name} {Size} {Type}";
        }
    }
}