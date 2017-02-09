using System;
using System.ComponentModel.DataAnnotations;

namespace StartWithWindowsForm
{
    public class AnimalType : IdEntity
    {
        [Required, MaxLength(200)]
        public string Name { get; set; }
        public virtual AnimalType Parent { get; set; }
    }
}