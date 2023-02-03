using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Core.DataAccess.EntityFramework;
using EntityFramework.SQLDataBase.Entities.Concrete;

namespace EntityFramework.SQLDataBase.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepository<Order, NorthwindContext>, Abstract.IOrderDal
    {
        public List<Order> GetAll()
        {
            using(var context = new NorthwindContext())
            {
                var result = from p in context.Orders
                             select new Order
                             {
                                 CustomerID = p.CustomerID,
                                 OrderDate = p.OrderDate,
                                 EmployeeID = p.EmployeeID,
                                 RequiredDate = p.RequiredDate,
                                 ShippedDate = p.ShippedDate,
                             };
                return result.ToList();
            }
        }
    }
}
