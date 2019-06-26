using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ProfilesBL
{
    class CategoryProfileBL : Profile
    {
        public CategoryProfileBL()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

        }
    }
}
