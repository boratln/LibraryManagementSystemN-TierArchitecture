using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Member
    {
        public int MemberId {  get; set; }
        public string MemberName { get; set; }
        public string MemberSurname {  get; set; }
        public int Age {  get; set; }
        public List<BookLoan> Loans { get; set; }

    }
}
