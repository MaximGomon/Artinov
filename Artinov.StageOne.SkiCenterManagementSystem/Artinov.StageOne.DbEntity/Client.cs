using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Artinov.StageOne.DbEntity.Enums;

namespace Artinov.StageOne.DbEntity
{
    public abstract class Client : NameEntity
    {
        public int Age { get; set; }
        public Sex Sex { get; set; }
    }
}