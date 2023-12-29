using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            ProductManager productManager2 = new ProductManager(new EfProductDal());
            
            productManager2.Add(new Product(){ProductName = "Masa",CategoryId = 2, UnitPrice = 11, UnitsInStock = 5});

            foreach (var product in productManager2.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            //foreach (var product in productManager2.GetByUnitPrice(5,15))
            //{
            //    Console.WriteLine(product.ProductName + "----" + product.UnitPrice);
            //}
        }
    }
}
