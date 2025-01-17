using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Persistence.Repositories
{
    public class Repository <T> :IRepository<T> where T: class
    {
        private readonly LibraryManagementContext _context;

        public Repository(LibraryManagementContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
           _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
           _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
