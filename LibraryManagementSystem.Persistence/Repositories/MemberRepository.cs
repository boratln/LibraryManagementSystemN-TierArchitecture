using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Persistence.Repositories
{
    public class MemberRepository : Repository<Entities.Member>, IMemberRepository
    {
        public MemberRepository(LibraryManagementContext context) : base(context)
        {
        }
    }
}
