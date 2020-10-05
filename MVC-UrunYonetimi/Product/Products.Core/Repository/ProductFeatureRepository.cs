using Product.Core.Infrastructure;
using Product.Data.DataContext;
using Product.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Product.Core.Repository
{
  public  class ProductFeatureRepository : IProductFeatureRepository
    {
        private readonly ProductContext _context = new ProductContext();
        public int Count()
        {
            return _context.ProductFeature.Count();
        }

        public void Delete(int id)
        {
            var productfeature = GetById(id);
            if (productfeature != null)
            {
                _context.ProductFeature.Remove(productfeature);
            }
        }

        public ProductFeature Get(Expression<Func<ProductFeature, bool>> expression)
        {
            return _context.ProductFeature.FirstOrDefault(expression);
        }

        public IEnumerable<ProductFeature> GetAll()
        {
            return _context.ProductFeature.Select(x => x);
        }

        public ProductFeature GetById(int id)
        {
            return _context.ProductFeature.FirstOrDefault(x => x.ProductFeatureId == id);
        }

        public IQueryable<ProductFeature> GetMany(Expression<Func<ProductFeature, bool>> expression)
        {
            return _context.ProductFeature.Where(expression);
        }

        public void Insert(ProductFeature obj)
        {
            _context.ProductFeature.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        public void Update(ProductFeature obj)
        {
            _context.ProductFeature.AddOrUpdate(obj);
        }

    }
}
