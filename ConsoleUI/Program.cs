﻿
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            foreach (var item in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(item.ProductName);
            }

        }
    }
}
