using PlaceFinder.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ServiceInterfaces
{
    public interface ICategoryService
    {
        CategoryDTO GetCategoryById(int id);
        CategoryDTO GetCategoryByName(string name);
        void Insert(CategoryDTO category);
        void Update(CategoryDTO category);
        void Delete(CategoryDTO category);
    }
}
