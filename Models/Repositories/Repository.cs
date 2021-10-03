using System;
using System.Collections.Generic;
using System.Linq;
using HotDesk.Models;

namespace HotDesk.Models.Repositories
{
    public class Repository : IRepository
    {
        private readonly Context _context;

        public Repository(Context context) => _context = context;

        public T Get<T>(Func<T, bool> predicate) where T : class
        {
            return _context.Set<T>().Where(predicate).FirstOrDefault();
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Add<T>(T item) where T : class
        {
            _context.Set<T>().Add(item);
        }

        public void Remove<T>(T item) where T : class
        {
            _context.Set<T>().Remove(item);
        }

        public void SaveChanges() => _context.SaveChanges();
    }
}