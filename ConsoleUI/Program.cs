using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            ProductManager productManager2 = new ProductManager(new EfProductDal());
            

            

            foreach (var product in productManager2.GetByUnitPrice(5,15))
            {
                Console.WriteLine(product.ProductName + "----" + product.UnitPrice);
            }
        }
    }
}
