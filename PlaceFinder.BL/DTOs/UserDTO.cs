using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.DTOs
{
    public class UserDTO : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
