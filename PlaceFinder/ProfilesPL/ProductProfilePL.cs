using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceFinder.ProfilesPL
{
    public class ProductProfilePL : Profile
    {
        public ProductProfilePL()
        {
            CreateMap<ProductVM, ProductDTO>();
            CreateMap<ProductDTO, ProductVM>();
        }
    }
}
