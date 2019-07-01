using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ProfilesBL
{
    class ProductProfileBL : Profile
    {
        public ProductProfileBL()
        {
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();
        }
    }
}
