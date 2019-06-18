using System;
using System.Collections.Generic;

namespace PlaceFinder.DAL.Models
{
    public partial class PlaceProduct
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }

        public Place Place { get; set; }
        public Product Product { get; set; }
    }
}
