using CoreV2.DataAccess.EntityFramework;
using DataAccessV2.Abstract;
using EntitiesV2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessV2.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext> ,ICategoryDal
    {
       
    }
}
