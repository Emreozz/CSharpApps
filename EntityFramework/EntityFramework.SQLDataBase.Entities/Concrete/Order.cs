using EntityFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.SQLDataBase.Entities.Concrete
{
    public class Order:IEntity
    {
        public virtual int OrderID { get; set; }
        public virtual int CustomerID { get; set; }
        public virtual string EmployeeID { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual DateTime RequiredDate { get; set; }
        public virtual DateTime ShippedDate { get; set; }


    }
}
