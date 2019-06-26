using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.BL.ServiceInterfaces;
using PlaceFinder.DAL.Models;
using PlaceFinder.DAL.UoW;

namespace PlaceFinder.BL.Services
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public CategoryDTO GetCategoryById(int id)
        {
            var category = _unitOfWork.CategoryRepository.GetByID(id);
            CategoryDTO _category = _mapper.Map<CategoryDTO>(category);
            return _category;
            //without Automapper
            //return new CategoryDTO
            //{ Id = category.Id,Name = category.Name,ParentId = category.ParentId};
        }

        public CategoryDTO GetCategoryByName(string name)
        {
            return new CategoryDTO { };
        }

        public void Insert(CategoryDTO category)
        {
            Category _category = _mapper.Map<Category>(category);
            _unitOfWork.CategoryRepository.Insert(_category);
            _unitOfWork.Save();
            //var _category = new Category
            //{ Name = category.Name,ParentId = category.ParentId };
        }

        public void Update(CategoryDTO category)
        {
            Category _category = _mapper.Map<Category>(category);
            _unitOfWork.CategoryRepository.Update(_category);
            _unitOfWork.Save();
        }
        public void Delete(CategoryDTO category)
        {
            Category _category = _mapper.Map<Category>(category);
            _unitOfWork.CategoryRepository.Delete(_category);
            _unitOfWork.Save();
            //var _category = new Category
            //{ Id = category.Id,Name = category.Name,ParentId = category.ParentId   };
        }

    }
}
