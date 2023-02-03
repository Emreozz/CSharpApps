using EntityFramework.Core.DataAccess;
using EntityFramework.SQLDataBase.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.SQLDataBase.DataAccess.Abstract
{
    public interface IEmployeeDal: IEntityRepository<Employee>
    {
        List<Employee> GetAll();
    }
}
