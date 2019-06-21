using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ProfilesBL
{
    class ClientProfileBL : Profile
    {
        public ClientProfileBL()
        {
            CreateMap<Client, ClientDTO>();
        }
    }
}
