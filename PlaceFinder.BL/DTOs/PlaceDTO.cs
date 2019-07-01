using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.DTOs
{
    public class PlaceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public int ClientId { get; set; }
    }
}
