using CoreV2.DataAccess;
using EntitiesV2.Concrete;
using EntitiesV2.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessV2.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
