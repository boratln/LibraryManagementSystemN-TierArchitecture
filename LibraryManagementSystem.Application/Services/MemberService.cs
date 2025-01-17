using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repository;

        public MemberService(IMemberRepository repository)
        {
            _repository = repository;
        }

        public void TAdd(Member entity)
        {
            _repository.Add(entity);

        }

        public void TDelete(Member entity)
        {
            _repository.Delete(entity);
        }

        public Member TGetById(int id)
        {
            return _repository.GetById(id);

        }

        public List<Member> TGetListAll()
        {
            return _repository.GetAll();
        }

        public void TUpdate(Member entity)
        {
            _repository.Update(entity);
        }
    }
}
