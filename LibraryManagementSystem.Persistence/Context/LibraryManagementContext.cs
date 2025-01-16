using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Persistence.Context
{
    public class LibraryManagementContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BORAPC;Initial Catalog=LibraryManagementSystemWeb;User Id=bora;Password=123; TrustServerCertificate=True");
        }
        DbSet<Author> Authors { get; set; }
        DbSet<Member> Members { get; set; }
        DbSet<BookLoan> Loans { get; set; }
        DbSet<Book> Books { get; set; }
    }
}
