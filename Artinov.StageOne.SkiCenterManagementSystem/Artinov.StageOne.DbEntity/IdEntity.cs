using System;
using System.ComponentModel.DataAnnotations;

namespace Artinov.StageOne.DbEntity
{
    public abstract class IdEntity
    {
        [Key]
        public Guid Id { get; set; }

        protected IdEntity()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        public bool IsDeleted { get; set; }
    }
}
