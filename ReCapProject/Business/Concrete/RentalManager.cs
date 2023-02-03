using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var carCheck=_rentalDal.GetAll(p => p.CarId == rental.CarId);
            
            foreach (var item in carCheck)
            {
                if (item.ReturnDate == null)
                {
                    return new ErrorResult(Messages.RentInvalid);
                }
                return new SuccessResult(Messages.RentalAdded);
            }
            //if (rental.CarId)
            //{
            //    _rentalDal.Add(rental);
            //    return new ErrorResult(Messages.RentalAdded);
            //}
            return new SuccessResult(Messages.RentInvalid);
        }

        public IDataResult<Rental> GetAll()
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetAll(p => p.Id == id));
        }
    }
}
