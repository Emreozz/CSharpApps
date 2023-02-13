using BusinessV2.Abstract;
using CoreV2.Utilities.Results;
using DataAccessV2.Abstract;
using EntitiesV2.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessV2.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>> (_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category> (_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
