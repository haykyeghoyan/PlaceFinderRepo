using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceFinder.VMs
{
    public class PlaceVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public int ClientId { get; set; }
    }
}
