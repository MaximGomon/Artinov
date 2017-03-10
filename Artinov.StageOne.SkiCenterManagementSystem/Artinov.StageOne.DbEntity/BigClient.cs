using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Artinov.StageOne.DbEntity
{
    public class BigClient : Client
    {
        public virtual ICollection<Phone> Phones { get; set; }
        [Required]
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<LittleClient> Childs { get; set; } 
    }
}