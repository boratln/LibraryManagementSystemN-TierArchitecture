using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dtos.BookDtos
{
    public class CreateBookDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockCount { get; set; }
        public int AuthorId { get; set; }
    }
}
