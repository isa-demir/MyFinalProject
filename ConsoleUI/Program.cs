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
            //ProductTest();
            CategoryTest();
            //OrderTest();

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductName + " : " + p.UnitPrice);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryId + " " + item.CategoryName);
            }
        }

        private static void OrderTest()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var o in orderManager.GetAll())
            {
                Console.WriteLine(o.OrderId + " " + o.ShipCity);
            }
        }
    }
}
