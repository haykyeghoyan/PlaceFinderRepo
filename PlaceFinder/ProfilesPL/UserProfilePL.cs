using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceFinder.ProfilesPL
{
    public class UserProfilePL : Profile
    {
        public UserProfilePL()
        {
            CreateMap<UserDTO, UserVM>();
            CreateMap<UserVM, UserDTO>();
        }
    }
}
