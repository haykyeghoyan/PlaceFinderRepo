using System;
using System.Collections.Generic;

namespace PlaceFinder.DAL.Models
{
    public partial class Client
    {
        public Client()
        {
            Place = new HashSet<Place>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Place> Place { get; set; }
    }
}
