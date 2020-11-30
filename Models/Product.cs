using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Models
{
    public class Product
    {
        public long ProductID { get; set; }

        public string ImageProduct { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Categories { get; set; }

    }
}
