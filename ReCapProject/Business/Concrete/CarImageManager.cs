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
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using Image = System.Drawing.Image;
using Microsoft.AspNetCore.Http;
using Core.Utilities.Helpers.FileHelper;
using FluentValidation.Results;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;
        
        
        public CarImageManager(ICarImageDal carImageDal,IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;   
        }
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = CheckIfCarImageLimit(carImage.CarId);
            if(result.Success!=true)
            {
                return result;
            }
            carImage.ImagePath = _fileHelper.Upload(file, Paths.FilePath);
            carImage.Date=DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.ImageUploaded);
            //carImage.ImagePath=SaveImage(carImage);      
            //_carImageDal.Add(carImage);
            //return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(int id)
        {
            var deleted = _carImageDal.GetAll(p => p.Id ==id);
            _fileHelper.Delete(Paths.FilePath + deleted[0].ImagePath);
            _carImageDal.Delete(deleted[0]);
            return new SuccessResult(Messages.ImageDeleted);
        }

        public IDataResult<CarImage> Get(int id)
        {
            return GetDefaultImage(id);         
        }

        public IDataResult<CarImage> GetAll()
        {
            return GetDefaultImageForAll();
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            var updated = _carImageDal.GetAll(p => p.Id == carImage.Id);
            carImage.ImagePath=_fileHelper.Update(file, Paths.FilePath+carImage.ImagePath,Paths.FilePath);
            _carImageDal.Update(updated[0]);
            return new SuccessResult(Messages.CustomerUpdated);
        }
        //private bool CheckIfAlreadyThereIsAnotherValue()
        //{
        //    if ((new SuccessDataResult<CarImage>(_carImageDal.GetAll())).Data.Count() > 0)
        //        return new SuccessResult().Success;
        //    else
        //        return new ErrorResult().Success;
        //}
        //private string SaveImage(CarImage carImage)
        //{
        //    Image _image = Image.FromFile(carImage.ToString());
        //    carImage.ImagePath =(new Guid(carImage.ImagePath)).ToString();
        //    string imagePath = Paths.FilePath+carImage.ImagePath;
        //    _image.Save(imagePath, ImageFormat.Jpeg);
        //    return carImage.ImagePath;
        //}
        //private void DeleteImage(IFormFile file, CarImage carImage)
        //{
        //    if(File.Exists(carImage.ImagePath))
        //        File.Delete(carImage.ImagePath);
            
        //}
        private IDataResult<CarImage> GetDefaultImage(int id)
        {
            var result = _carImageDal.GetAll(p => p.Id == id);
           
            result[0].ImagePath = "DefaultImage.jpg";
              
            return new SuccessDataResult<CarImage>(result);
        }
        private IDataResult<CarImage> GetDefaultImageForAll()
        {
            var result = _carImageDal.GetAll();
            foreach(var data in result)
            {
                if (data.ImagePath == null)
                    data.ImagePath = "DefaultImage.jpg";
            }
            return new SuccessDataResult<CarImage>(result);

        }
        private IResult CheckIfCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carId).Count;
            if (result > 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
}
