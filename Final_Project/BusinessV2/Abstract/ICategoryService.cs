using CoreV2.Utilities.Results;
using EntitiesV2.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessV2.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
    }
}
