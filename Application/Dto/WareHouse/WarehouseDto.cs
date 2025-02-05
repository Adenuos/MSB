﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Dto.WareHouse
{
    public class WarehouseDto
    {
        [Key]
        public int? WarehouseId { get; set; }

        [ForeignKey("AddressId")]
        public int AddressId { get; set; }
        // public Address Address { get; set; }

        [ForeignKey("ShelfId")]
        public int ShelfId { get; set; }
        // public Shelf Shelf { get; set; }
    }
}
