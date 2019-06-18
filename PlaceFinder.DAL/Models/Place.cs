using System;
using System.Collections.Generic;

namespace PlaceFinder.DAL.Models
{
    public partial class Place
    {
        public Place()
        {
            PlaceProduct = new HashSet<PlaceProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public int ClientId { get; set; }

        public Client Client { get; set; }
        public ICollection<PlaceProduct> PlaceProduct { get; set; }
    }
}
