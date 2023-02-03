using CoreV2.DataAccess;
using EntitiesV2.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessV2.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
