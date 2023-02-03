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
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.ProductAdded);
            }
            return new ErrorResult(Messages.ProductNameInvalid);
            // ya da Result result= new Result()
            //result.Success =
            //result.Message = //setleme islemi burada olmaz cünkü propertyde sadece get var 
            //return result

        }

        public IDataResult<Car> GetAll()
        {
            return new SuccessDataResult<Car>(_carDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<Car> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<Car> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.GetAll(p => p.ColorId == id));
        }
    }
}
