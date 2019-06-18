using PlaceFinder.BL.DTOs;
using PlaceFinder.BL.ServiceInterfaces;
using PlaceFinder.DAL.Models;
using PlaceFinder.DAL.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.Services
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public CategoryDTO GetCategoryById(int id)
        {
            var category = unitOfWork.CategoryRepository.GetByID(id);

            return new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId
            };
        }

        public CategoryDTO GetCategoryByName(string name)
        {
            return new CategoryDTO { };
        }

        public void Insert(CategoryDTO model)
        {
            var category = new Category
            {
                Name = model.Name,
                ParentId = model.ParentId
            };
            unitOfWork.CategoryRepository.Insert(category);
            unitOfWork.Save();
        }

        public void Update(CategoryDTO model)
        {
            var category = new Category
            {
                Id = model.Id,
                Name = model.Name,
                ParentId = model.ParentId
            };
            unitOfWork.CategoryRepository.Update(category);
            unitOfWork.Save();
        }
        public void Delete(CategoryDTO model)
        {
            var category = new Category
            {
                Id = model.Id,
                Name = model.Name,
                ParentId = model.ParentId
            };
            unitOfWork.CategoryRepository.Delete(category);
            unitOfWork.Save();
        }

    }
}
