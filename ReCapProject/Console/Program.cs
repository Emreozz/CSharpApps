using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

RentalManager rentalManager = new RentalManager(new EfRentalDal());
//carManager.Add(new Car { BrandId = 1, ColorId =3, DailyPrice = 250, Description = "Cool man", Id = 6, ModelYear = 2022 });
rentalManager.Add(new Rental
{ CarId = 5, CustomerId = 5, RentDate = new DateTime(2001, 07, 15), ReturnDate = new DateTime(2001, 08, 05) });
var result = rentalManager.GetAll();

if (result.Success)
{
    foreach (var item in result.Data)
    {

        Console.WriteLine(item.Id);
    }
    //Console.WriteLine(result.Message);
}
