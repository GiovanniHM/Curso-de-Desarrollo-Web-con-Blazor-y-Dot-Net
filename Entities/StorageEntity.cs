using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
   public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        // Relationship with produc
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        // Relationship with Wherehouse
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        //Relationship with Input
        public ICollection<InputOutputEntity> inputOutputs { get; set; }

    }
}
