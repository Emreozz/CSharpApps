using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<CarImage> GetAll();
        IDataResult<CarImage> Get(int id);
        IResult Add(IFormFile file,CarImage customer);
        IResult Delete(int id);
        IResult Update(IFormFile file,CarImage carImage);
    }
}
