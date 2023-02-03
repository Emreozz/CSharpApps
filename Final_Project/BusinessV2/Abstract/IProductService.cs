using CoreV2.Utilities.Results;
using EntitiesV2.Concrete;
using EntitiesV2.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessV2.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IDataResult<Product> GetById(int productId);
        IResult Update(Product product);

        IResult AddTransactionalTest(Product product);
        //Restful--> HTTP -->
     }
}
