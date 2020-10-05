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
  public class CategoryRepository : ICategoryRepository
    {
    
        private readonly ProductContext _context = new ProductContext();
        public int Count()
        {
            return _context.Category.Count();
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            if(category!=null)
            {
                _context.Category.Remove(category);
            }
                
          
        }

        public Category Get(Expression<Func<Category, bool>> expression)
        {
            return _context.Category.FirstOrDefault(expression);
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Category.Select(x => x);
        }

        public Category GetById(int id)
        {
            return _context.Category.FirstOrDefault(x => x.CategoryId == id);
        }

        public IQueryable<Category> GetMany(Expression<Func<Category, bool>> expression)
        {
            return _context.Category.Where(expression);
        }

        public void Insert(Category obj)
        {
            obj.CategoryName = obj.CategoryName.ToUpper();
            _context.Category.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category obj)
        {
            obj.CategoryName = obj.CategoryName.ToUpper();
            _context.Category.AddOrUpdate(obj);
        }
    }
}
