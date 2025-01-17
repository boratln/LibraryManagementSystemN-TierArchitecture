using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Services
{
    public class BookLoanService : IBookLoanService
    {
        private readonly IBookLoanRepository _repository;

        public BookLoanService(IBookLoanRepository repository)
        {
            _repository = repository;
        }

        public void TAdd(BookLoan entity)
        {
            _repository.Add(entity);

        }

        public void TDelete(BookLoan entity)
        {
            _repository.Delete(entity);
        }

        public BookLoan TGetById(int id)
        {
            return _repository.GetById(id);

        }

        public List<BookLoan> TGetListAll()
        {
            return _repository.GetAll();
        }

        public void TUpdate(BookLoan entity)
        {
            _repository.Update(entity);
        }
    }
}
