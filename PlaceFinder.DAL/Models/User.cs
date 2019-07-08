using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace PlaceFinder.DAL.Models
{
    public partial class User : IdentityUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
