using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [StringLength(100)]
        [Required]
        public string ProductName { get; set; }
        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        // Relación con categorías (CategoryEntity)
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //Relación con almacenamiento (StorageEntity)
        //Un "producto" puede estar en varios "almacénes"
        public ICollection<StorageEntity> Storages { set; get; }
    }
}
