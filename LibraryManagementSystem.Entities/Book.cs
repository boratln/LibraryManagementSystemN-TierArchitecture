using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Book
    {
        public int BookId {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PageCount {  get; set; }
        public string BookUrl { get; set; }
        public decimal UnitPrice {  get; set; }
        public int StockCount {  get; set; }
        public int AuthorId {  get; set; }
        public Author Author { get; set; }
    }
}
