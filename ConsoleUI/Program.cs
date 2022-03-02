
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            UnitPriceProduct();
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }

        }

        private static void UnitPriceProduct()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            foreach (var item in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
