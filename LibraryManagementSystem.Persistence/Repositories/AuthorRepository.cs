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
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryManagementContext context) : base(context)
        {

        }

        public Author SearchAuthor(string word)
        {
            using var context = new LibraryManagementContext();
            context.
        }
    }
}
