﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Artinov.StageOne.DbEntity.Enums;

namespace Artinov.StageOne.DbEntity
{
    public class Order : IdEntity
    {
        public Order()
        {
            OrderElements = new List<WarehouseElement>();
        }

        [Required, MaxLength(20)]
        public string Number { get; set; }
        [Required]
        public virtual ICollection<WarehouseElement> OrderElements { get; set; }
        [Required]
        public OrderState State { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public virtual Client Client { get; set; }
        [Required]
        public virtual User Author { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
    }
}