using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.InMemory.Entity_Framerwork;
using System;

namespace ConsoleUI
{
    //SOLID     LINQ
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //IoC
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var product in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
