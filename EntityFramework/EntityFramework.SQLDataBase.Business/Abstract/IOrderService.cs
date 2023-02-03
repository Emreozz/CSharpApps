using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.SQLDataBase.Entities.Concrete;

namespace EntityFramework.SQLDataBase.Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
    }
}
