using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductName);
            }
            var l1 = productManager.GetAllByCategoryId(1);
            var l2 = productManager.GetByUnitPrice(50, 100);
            Console.WriteLine("----------------------------------");
            foreach (var p in l1)
            {
                Console.WriteLine(p.ProductName + " " + p.CategoryId);
            }
            Console.WriteLine("----------------------------------");
            foreach (var p in l2)
            {
                Console.WriteLine(p.ProductName + " " + p.UnitPrice);
            }
        }
    }
}
