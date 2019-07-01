using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceFinder.ProfilesPL
{
    public class PlaceProfilePL : Profile
    {
        public PlaceProfilePL()
        {
            CreateMap<PlaceVM, PlaceDTO>();
            CreateMap<PlaceDTO, PlaceVM>();
        }
    }
}
