using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Product.Core.Infrastructure
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        //Tek nesne için
        T Get(Expression<Func<T, bool>> expression);
        //Birden fazla nesne için
        IQueryable<T> GetMany(Expression<Func<T, bool>> expression);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        int Count();
        void Save();
    }
}
