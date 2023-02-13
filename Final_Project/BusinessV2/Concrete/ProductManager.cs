using EntitiesV2.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessV2.Abstract;
using EntitiesV2.DTOs;
using CoreV2.Utilities.Results;
using BusinessV2.Constants;
using DataAccessV2.Abstract;
using FluentValidation;
using BusinessV2.ValidationRules.FluentValidation;
using CoreV2.CrossCuttingConcerns.Validation;
using CoreV2.Aspects.Autofac.Validation;
using CoreV2.Utilities.Business;
using BusinessV2.BusinessAspects.Autofac;
using CoreV2.Aspects.Autofac.Caching;
using CoreV2.Aspects.Autofac.Transaction;
using CoreV2.Aspects.Autofac.Performance;

namespace BusinessV2.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;
        
        public ProductManager(IProductDal productDal,ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
            
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Product product)
        {
            IResult result = BusinessRules.Run(CheckIfProductCountOfCategoryCorrect(product.CategoryId), 
                CheckIfProductNameIsAlreadyExist(product.ProductName),CheckIfCategoryLimitExceed());

            if (result != null)
            {
                return result;
            }

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
            
        }
        [CacheAspect]//key,value
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 10)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(P => P.UnitPrice >= min && P.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Product product)
        {
            var result = _productDal.GetAll(p => p.CategoryId == product.CategoryId).Count;
            if (result >= 10)
                return new ErrorResult(Messages.ProductCountCategoryError);
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductAdded);
        }
        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
            if (result >= 10)
                return new ErrorResult(Messages.ProductCountCategoryError);
            return new SuccessResult();
        }
        private IResult CheckIfProductNameIsAlreadyExist(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();
            if(result)
                return new ErrorResult(Messages.ProductNameInvalid);
            return new SuccessResult();
        }
        private IResult CheckIfCategoryLimitExceed()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count > 15)
                return new ErrorResult(Messages.categoryLimitExceed);
            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
