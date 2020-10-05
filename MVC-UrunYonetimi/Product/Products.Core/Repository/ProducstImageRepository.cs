using Product.Core.Infrastructure;
using Product.Data.DataContext;
using Product.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace Product.Core.Repository
{
    public  class ProducstImageRepository : IProductImageRepository
    {
        private readonly ProductContext _context = new ProductContext();
        public int Count()
        {
            return _context.ProductImage.Count();
        }

        public void Delete(int id)
        {
            var productimage = GetById(id);
            if (productimage != null)
            {
                _context.ProductImage.Remove(productimage);
            }


        }



       
        public ProductImage Get(Expression<Func<ProductImage, bool>> expression)
        {
            return _context.ProductImage.FirstOrDefault(expression);
        }

        public IEnumerable<ProductImage> GetAll()
        {
            return _context.ProductImage.Select(x => x);
        }

        public ProductImage GetById(int id)
        {
            return _context.ProductImage.FirstOrDefault(x => x.ProductImageId == id);
        }

        public IQueryable<ProductImage> GetMany(Expression<Func<ProductImage, bool>> expression)
        {
            return _context.ProductImage.Where(expression);
        }

        public void Insert(ProductImage obj)
        {
            _context.ProductImage.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void Update(ProductImage obj)
        {
            _context.ProductImage.AddOrUpdate(obj);
        }

    }
}
