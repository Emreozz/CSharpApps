using EntityFramework.Core.DataAccess;
using EntityFramework.SQLDataBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.SQLDataBase.DataAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<Order>
    {
        List<Order> GetAll();
    }
}
