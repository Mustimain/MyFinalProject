using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);

        Product GetById(int productId);

        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int Id);

        List<Product> GetByUnitPrice(decimal min, decimal max);

        List<ProductDetailDto> GetProductDetails();
    }
}
