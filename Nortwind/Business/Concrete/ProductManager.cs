using Business.Abstract;
using DataAccess.Abstract;
using Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public void Add(Product p)
        {
            _ProductDal.Add(p);
        }

        public List<Product> GetAll()
        {
            return _ProductDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _ProductDal.GetList(filter: p => p.CategoryId == categoryId);
        }
        public Product GetById(int productId)
        {
            return _ProductDal.Get(filter: p => p.ProductId == productId);
        }
    }
}
