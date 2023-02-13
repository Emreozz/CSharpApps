using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICustomerService _customerService;
        public RentalManager(IRentalDal rentalDal, ICustomerService customerService)
        {
            _rentalDal = rentalDal;
            _customerService = customerService;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            IResult result= BusinessRules.Run(CheckIfProductCountOfCategoryCorrect(rental.CarId),
                CheckIfTheCarWillRentDoesNotComeBackYet(rental));

            if (result != null)
            {
                return result;
                
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);

        }

        public IResult Delete(int id)
        {
            
            var deleted = _rentalDal.GetAll(p => p.CustomerId == id);

            _rentalDal.Delete(deleted[0]);
            
            
            return new SuccessResult(Messages.CustomerDeleted);
            
        }

        public IResult DeleteRentalInCustomer(int id)
        {
            _customerService.Delete(id);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<Rental> GetAll()
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetAll(p => p.Id == id));
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfProductCountOfCategoryCorrect(int customerId)
        {
            var result= _rentalDal.GetAll(p=>p.CustomerId == customerId).Count;
            if (result > 15)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
        private IResult CheckIfTheCarWillRentDoesNotComeBackYet(Rental rental)
        {
            var carCheck = _rentalDal.GetAll(p => p.CarId == rental.CarId);
            foreach (var item in carCheck)
            {
                if (item.ReturnDate == null)
                {
                    return new ErrorResult();
                }
            }
            return new SuccessResult();
        }
    }
}
