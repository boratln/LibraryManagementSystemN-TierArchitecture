using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Persistence.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryManagementContext context) : base(context)
        {
        }
    }
}
