using PlaceFinder.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.BL.ServiceInterfaces
{
    public interface IProductService
    {
        ProductDTO GetProductById(int id);
        ProductDTO GetProductByName(string name);
        void Insert(ProductDTO product);
        void Update(ProductDTO product);
        void Delete(ProductDTO product);
    }
}
