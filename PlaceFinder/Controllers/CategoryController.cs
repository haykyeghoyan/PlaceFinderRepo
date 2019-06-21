using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
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
            var category = categoryService.GetCategoryById(id);
            var response = new CategoryVM
            {
                Id = category.Id,
                Name = category.Name
            };
            return response;
        }



        // POST: api/Category
        [HttpPost]
        public void Post([FromBody] CategoryVM model)
        {
            var category = new CategoryDTO
            {
                Name = model.Name,
                ParentId = model.Parent
            };
            categoryService.Insert(category);

        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] CategoryVM model)
        {
           
            var category = new CategoryDTO
            {
                Id = id,
                Name = model.Name,
                ParentId = model.Parent
            };
            categoryService.Update(category);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] CategoryVM model)
        {
            var category = new CategoryDTO
            {
                Id = id,
                Name = model.Name,
                ParentId = model.Parent
            };

            categoryService.Delete(category);

        }
    }
}
