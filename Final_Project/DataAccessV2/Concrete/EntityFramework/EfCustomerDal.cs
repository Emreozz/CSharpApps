using CoreV2.DataAccess.EntityFramework;
using DataAccessV2.Abstract;
using EntitiesV2.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessV2.Concrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer,NorthwindContext>, ICustomerDal
    {
    }
}
