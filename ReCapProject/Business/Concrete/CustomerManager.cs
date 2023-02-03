using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(int id)
        {
            var deleted=_customerDal.GetAll(p=>p.UserId==id);
            _customerDal.Delete(deleted[0]);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<Customer> Get(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.GetAll(p => p.Id == id));
        }

        public IDataResult<Customer> GetAll()
        {
            return new SuccessDataResult<Customer>(_customerDal.GetAll());
        }

        public IResult Update(Customer customer)
        {
            var deleted = _customerDal.GetAll(p => p.Id == customer.Id);
            _customerDal.Update(deleted[0]);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
