using AutoMapper;
using PlaceFinder.BL.DTOs;
using PlaceFinder.BL.ServiceInterfaces;
using PlaceFinder.DAL.Models;
using PlaceFinder.DAL.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public ProductDTO GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetProductById(int id)
        {
            var product = _unitOfWork.ProductRepository.GetByID(id);
            ProductDTO _product = _mapper.Map<ProductDTO>(product);
            return _product;
        }

        public void Insert(ProductDTO product)
        {
            Product _product = _mapper.Map<Product>(product);
            _unitOfWork.ProductRepository.Insert(_product);
            _unitOfWork.Save();
        }

        public void Update(ProductDTO product)
        {
            Product _product = _mapper.Map<Product>(product);
            _unitOfWork.ProductRepository.Update(_product);
            _unitOfWork.Save();
        }

        public void Delete(ProductDTO product)
        {
            Product _product = _mapper.Map<Product>(product);
            _unitOfWork.ProductRepository.Delete(_product);
            _unitOfWork.Save();
        }
    }
}
