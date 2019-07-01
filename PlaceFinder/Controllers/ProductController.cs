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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        // GET: api/Product
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public ProductVM Get(int id)
        {
            var product = _productService.GetProductById(id);
            ProductVM response = _mapper.Map<ProductVM>(product);
            return response;
        }

        // POST: api/Product
        [HttpPost]
        public void Post([FromBody] ProductVM product)
        {
            ProductDTO _product = _mapper.Map<ProductDTO>(product);
            _productService.Insert(_product);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductVM product)
        {
            ProductDTO _product = _mapper.Map<ProductDTO>(product);
            _product.Id = id;
            _productService.Update(_product);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] ProductVM product)
        {
            ProductDTO _product = _mapper.Map<ProductDTO>(product);
            _product.Id = id;
            _productService.Delete(_product);
        }
    }
}
