using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ProfilesBL
{
    class PlaceProfileBL : Profile
    {
        public PlaceProfileBL()
        {
            CreateMap<Place, PlaceDTO>();
            CreateMap<PlaceDTO, Place>();
        }
    }
}
