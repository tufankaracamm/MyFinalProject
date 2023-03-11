using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _IproductDal;

        public ProductManager(IProductDal ıproductDal)
        {
            _IproductDal = ıproductDal;
        }

        public List<Product> GetAll()
        {
            return _IproductDal.GetAll();
        }

        public List<Product> GetAllByCategory(int id)
        {
            return _IproductDal.GetAll(p=> p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _IproductDal.GetAll(p=> p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
