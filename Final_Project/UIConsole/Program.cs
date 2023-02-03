using Business.Abstract;
using DataAccess.Concrete.EntityFramework;

static void Main()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach(var product in productManager.GetAll())
    {
        Console.WriteLine(product.ProductName);
        Console.ReadLine();
    }
}