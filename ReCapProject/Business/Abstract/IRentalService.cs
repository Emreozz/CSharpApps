using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetAll();
        IResult Add(Rental rental);
        IDataResult<Rental> GetById(int id);
        IResult Update(Rental rental);
        IResult Delete(int id);
        IResult DeleteRentalInCustomer(int id);
       
    }
}
