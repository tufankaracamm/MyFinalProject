using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
               _products= new List<Product>
               {
                   new Product{ProductId = 1 , CategoryId = 1, ProductName = "bardak",
                       UnitPrice= 15, UnitsInStock= 15},
                   new Product{ProductId = 2 , CategoryId = 2, ProductName = "kamera",
                       UnitPrice= 3, UnitsInStock= 500},
                   new Product{ProductId = 3 , CategoryId = 3, ProductName = "telefon",
                       UnitPrice= 2, UnitsInStock= 1500},
                   new Product{ProductId = 4 , CategoryId = 4, ProductName = "klavye",
                       UnitPrice= 65, UnitsInStock= 150},
                   new Product{ProductId = 5 , CategoryId = 5, ProductName = "mouse",
                       UnitPrice= 1, UnitsInStock= 85}

               };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            
            Product ProductToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(ProductToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
             return _products.Where(p => p.ProductId== categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.CategoryId = product.CategoryId;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.UnitsInStock = product.UnitsInStock; 

        }
    }
}
