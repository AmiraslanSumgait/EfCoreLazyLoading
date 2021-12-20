using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingActivate.Models
{
    public class Product:BaseEntity
    {
        public string? Name { get; set; }
        public int Price { get; set; }
        public int Quantity{ get; set; }
        public virtual Category? Category { get; set; }
    }
}
