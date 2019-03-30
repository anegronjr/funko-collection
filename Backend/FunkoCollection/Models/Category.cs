using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunkoCollection.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual List<Funko> Funkos { get; set; }
    }
}
