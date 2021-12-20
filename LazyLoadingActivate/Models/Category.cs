using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingActivate.Models
{
    public class Category:BaseEntity
    {
        public string? Name { get; set; }
        public virtual List<Product> Books { get; set; } = new List<Product>();
    }
}
