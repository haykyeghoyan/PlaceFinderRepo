using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceFinder.VMs
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parent { get; set; }
    }
}
