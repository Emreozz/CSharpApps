using CoreV2.DataAccess.EntityFramework;
using DataAccessV2.Abstract;
using EntitiesV2.Concrete;
using EntitiesV2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessV2.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { 
                                 ProductId = p.ProductId, 
                                 ProductName = p.ProductName, 
                                 CategoryName = c.CategoryName, 
                                 UnitsInStock = p.UnitsInStock 
                             };
                return result.ToList();
            }
        }
    }
}