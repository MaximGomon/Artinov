using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Artinov.StageOne.DbEntity
{
    public class BigClient : Client
    {
        public BigClient()
        {
            Phones = new List<Phone>();
            Childs = new List<LittleClient>();
            RentEquipments = new List<WarehouseElement>();
            Documents = new List<Document>();
        }

        public virtual ICollection<Phone> Phones { get; set; }
        [Required]
        public virtual ICollection<Document> Documents { get; set; }

        public virtual ICollection<WarehouseElement> RentEquipments { get; set; }

        public virtual ICollection<LittleClient> Childs { get; set; } 
    }
}