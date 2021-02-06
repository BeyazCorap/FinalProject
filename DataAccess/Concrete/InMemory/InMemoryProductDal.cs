using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName= "Bardak",UnitsInStock = 15 , UnitPrice = 15},
                new Product{ProductId=2,CategoryId=1,ProductName= "Kamera",UnitsInStock = 500 , UnitPrice = 3},
                new Product{ProductId=3,CategoryId=2,ProductName= "Telefon",UnitsInStock = 1500 , UnitPrice = 2},
                new Product{ProductId=4,CategoryId=2,ProductName= "Klavye",UnitsInStock = 150 , UnitPrice = 65},
                new Product{ProductId=5,CategoryId=2,ProductName= "Fare",UnitsInStock = 85 , UnitPrice = 1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product ProductToDelete = null;
            //foreach (var p in _products)
            //{
            //    if(product.ProudctId == p.ProudctId)
            //    {
            //        ProductToDelete = p;
            //    }
            //}
            //same shit
            Product ProductToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);


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
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //find the product in the list that has the product id i sent
            Product ProductToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.CategoryId = product.CategoryId;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
