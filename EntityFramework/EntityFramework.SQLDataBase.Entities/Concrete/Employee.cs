using EntityFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.SQLDataBase.Entities.Concrete
{
    public class Employee : IEntity
    {
        public virtual int EmployeeID {get;set;}
        public virtual string FirstName {get;set;}
        public virtual string LastName {get;set;}
        public virtual string Title {get;set;}

    }
}
