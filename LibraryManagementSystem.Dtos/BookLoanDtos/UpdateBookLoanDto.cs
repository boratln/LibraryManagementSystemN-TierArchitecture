using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dtos.BookLoanDtos
{
    public class UpdateBookLoanDto
    {
        public int BookLoanId { get; set; }
        public int MemberId { get; set; }
    }
}
