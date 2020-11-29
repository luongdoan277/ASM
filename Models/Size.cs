using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Models
{
    public class Size
    {
        public long SizeID { get; set; }
        public string SizeName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
