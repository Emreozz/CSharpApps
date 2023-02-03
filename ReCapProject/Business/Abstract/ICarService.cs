using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetAll();
        IDataResult<Car> GetCarsByColorId(int id);
        IDataResult<Car> GetCarsByBrandId(int id);  
        IResult Add(Car car);
    }
}
