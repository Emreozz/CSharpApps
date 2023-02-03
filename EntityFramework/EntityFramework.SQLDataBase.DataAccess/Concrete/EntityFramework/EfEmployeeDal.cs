using EntityFramework.Core.DataAccess.EntityFramework;
using EntityFramework.SQLDataBase.DataAccess.Abstract;
using EntityFramework.SQLDataBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.SQLDataBase.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepository<Employee, NorthwindContext>, IEmployeeDal
    {
        public List<Employee> GetAll()
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Employees
                             select new Employee
                             {
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 Title = p.Title,
                             };
                return result.ToList();
            }
        }
    }
}
