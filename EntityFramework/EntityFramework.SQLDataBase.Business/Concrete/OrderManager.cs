using EntityFramework.SQLDataBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.SQLDataBase.DataAccess.Abstract;
using EntityFramework.SQLDataBase.Business.Abstract;

namespace EntityFramework.SQLDataBase.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetAll()
        {
            //Is kodlari
            //yetki var mi if'ler felan olacak burada
            return _orderDal.GetAll();
        }
    }
}
