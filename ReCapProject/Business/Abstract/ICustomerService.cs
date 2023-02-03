using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetAll();
        IDataResult<Customer> Get(int id);
        IResult Add(Customer customer);
        IResult Delete(int id);
        IResult Update (Customer customer);
    }
}
