using EntityFramework.SQLDataBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.SQLDataBase.DataAccess.Concrete.EntityFramework.Mappings
{
    public class OrderMap:EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable(@"Orders", @"dbo");
            HasKey(x => x.OrderID);
            Property(x => x.RequiredDate).HasColumnName("RequiredDate");
            Property(x => x.EmployeeID).HasColumnName("EmployeeID");
            Property(x => x.OrderDate).HasColumnName("OrderDate");
            Property(x => x.ShippedDate).HasColumnName("ShippedDate");
            Property(x => x.CustomerID).HasColumnName("CustomerID");
        }
    }
}
