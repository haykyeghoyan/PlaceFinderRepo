using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ProfilesBL
{
    class UserProfileBL : Profile
    {
        public UserProfileBL()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
