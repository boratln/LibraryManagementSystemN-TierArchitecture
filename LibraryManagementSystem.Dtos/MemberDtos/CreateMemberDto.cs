using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dtos.MemberDtos
{
    public class CreateMemberDto
    {
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public int Age { get; set; }
    }
}
