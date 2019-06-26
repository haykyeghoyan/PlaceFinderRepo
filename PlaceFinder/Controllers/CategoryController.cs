using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaceFinder.BL.DTOs;
using PlaceFinder.BL.ServiceInterfaces;
using PlaceFinder.VMs;

namespace PlaceFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        private IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }


        // GET: api/Category
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET: api/Category/5
        [HttpGet("{id}")]
        public CategoryVM Get(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            CategoryVM response = _mapper.Map<CategoryVM>(category);
            //var response = new CategoryVM
            //{Id = category.Id,Name = category.Name};
            return response;
        }

        // POST: api/Category
        [HttpPost]
        public void Post([FromBody] CategoryVM category)
        {
            CategoryDTO _category = _mapper.Map<CategoryDTO>(category);
            _categoryService.Insert(_category);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] CategoryVM category)
        {
            CategoryDTO _category = _mapper.Map<CategoryDTO>(category);
            _category.Id = id;
            _categoryService.Update(_category);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] CategoryVM category)
        {
            CategoryDTO _category = _mapper.Map<CategoryDTO>(category);
            _category.Id = id;
            _categoryService.Delete(_category);
        }
    }
}
