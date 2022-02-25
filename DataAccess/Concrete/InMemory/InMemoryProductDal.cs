using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        public static List<Product> _products = new List<Product>()
        {
            new Product(){ProductId = 1,CategoryId=1,ProductName="BARDAK",UnitsInStock=2,UnitPrice=5},
            new Product(){ProductId = 1,CategoryId=2,ProductName="FARE",UnitsInStock=3,UnitPrice=50},
            new Product(){ProductId = 1,CategoryId=3,ProductName="SEMSİYE",UnitsInStock=4,UnitPrice=500},
            new Product(){ProductId = 1,CategoryId=4,ProductName="KALEM",UnitsInStock=5,UnitPrice=5000},
            new Product(){ProductId = 1,CategoryId=5,ProductName="TERMOS",UnitsInStock=5,UnitPrice=50000}
        };
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product? productToDelete =null;
            productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryId == categoryID).ToList();
        }

        public void Update(Product product)
        {
            Product? productToUpdate = null;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
            
        }

        
    }
}
