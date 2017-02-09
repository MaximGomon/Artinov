using System;
using System.ComponentModel.DataAnnotations;

namespace StartWithWindowsForm
{
    public class IdEntity
    {
        public IdEntity()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; protected set; }
    }
}