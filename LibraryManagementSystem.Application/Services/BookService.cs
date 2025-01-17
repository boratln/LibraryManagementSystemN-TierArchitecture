using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public void TAdd(Book entity)
        {
            _repository.Add(entity);

        }

        public void TDelete(Book entity)
        {
            _repository.Delete(entity);
        }

        public Book TGetById(int id)
        {
            return _repository.GetById(id);

        }

        public List<Book> TGetListAll()
        {
            return _repository.GetAll();
        }

        public void TUpdate(Book entity)
        {
            _repository.Update(entity);
        }
    }
}
