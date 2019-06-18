using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }

       
    }
}
