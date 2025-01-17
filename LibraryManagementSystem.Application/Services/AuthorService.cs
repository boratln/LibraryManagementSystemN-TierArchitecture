using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _repository;

        public AuthorService(IAuthorRepository repository)
        {
            _repository = repository;
        }
        
        public void TAdd(Author entity)
        {
           _repository.Add(entity);
           
        }

        public void TDelete(Author entity)
        {
            _repository.Delete(entity);
        }

        public Author TGetById(int id)
        {
          return _repository.GetById(id);

        }

        public List<Author> TGetListAll()
        {
            return _repository.GetAll();
        }

        public Author TSearchAuthor(string word)
        {
           return _repository.SearchAuthor(word);
        }

        public void TUpdate(Author entity)
        {
          _repository.Update(entity);
        }
    }
}
