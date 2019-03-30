using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunkoCollection.Models
{
    public class Funko
    {
        public int FunkoId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual Category Category { get; set; }
    }
}
