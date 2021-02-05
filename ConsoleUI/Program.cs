using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{

    //SOLID
    //Open Closed Principle

    class Program
    {
        static void Main(string[] args)
        {
            
            ProductManager productManager = new ProductManager(new EfProductDal());

            Product product1 = new Product { CategoryId = 1, ProductId = 1, ProductName = "Elma", UnitPrice = 25, UnitsInStock = 5 };

            productManager.Add(product1);

            foreach (var product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
