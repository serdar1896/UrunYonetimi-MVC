using Product.Core.Infrastructure;
using Product.Data.DataContext;
using Product.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
namespace Product.Core.Repository
{
    public class ProductsRepocitory : IProductRepository
    {
        private readonly ProductContext _context = new ProductContext();
        public int Count()
        {
            return _context.Products.Count();
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }


        }

       

        public Products Get(Expression<Func<Products, bool>> expression)
        {
            return _context.Products.FirstOrDefault(expression);
        }

        public IEnumerable<Products> GetAll()
        {
            return _context.Products.Select(x => x);
        }

        public Products GetById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.ProductId== id);
        }

      

        public IQueryable<Products> GetMany(Expression<Func<Products, bool>> expression)
        {
            return _context.Products.Where(expression);
        }

       

        public void Insert(Products obj)
        {
            obj.ProductName = obj.ProductName.ToUpper();
            _context.Products.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void Update(Products obj)
        {
            obj.ProductName = obj.ProductName.ToUpper();
            _context.Products.AddOrUpdate(obj);
        }

      
    }
}
