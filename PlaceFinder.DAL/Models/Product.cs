using System;
using System.Collections.Generic;

namespace PlaceFinder.DAL.Models
{
    public partial class Product
    {
        public Product()
        {
            PlaceProduct = new HashSet<PlaceProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<PlaceProduct> PlaceProduct { get; set; }
    }
}
