using EntityFramework.SQLDataBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.SQLDataBase.DataAccess.Concrete.EntityFramework.Mappings
{
    public class EmployeeMap:EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable("Employees", @"dbo");
            HasKey(x => x.EmployeeID);
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.Title).HasColumnName("Title");
        }
    }
}
