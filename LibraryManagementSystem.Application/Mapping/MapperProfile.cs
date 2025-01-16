using AutoMapper;
using LibraryManagementSystem.Dtos.AuthorDtos;
using LibraryManagementSystem.Dtos.BookDtos;
using LibraryManagementSystem.Dtos.BookLoanDtos;
using LibraryManagementSystem.Dtos.MemberDtos;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //Book
            CreateMap<Book, CreateBookDto>().ReverseMap();
            CreateMap<Book, ResultBookDto>().ReverseMap();
            CreateMap<Book, UpdateBookDto>().ReverseMap();
            //Author
            CreateMap<Author, CreateAuthorDto>().ReverseMap();
            CreateMap<Author, ResultAuthorDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();

            //Member
            CreateMap<Member, CreateMemberDto>().ReverseMap();
            CreateMap<Member, ResultMemberDto>().ReverseMap();
            CreateMap<Member, UpdateMemberDto>().ReverseMap();

            //BookLoan
            CreateMap<BookLoan, CreateBookLoanDto>().ReverseMap();
            CreateMap<BookLoan, ResultBookLoanDto>().ReverseMap();
            CreateMap<BookLoan, UpdateBookLoanDto>().ReverseMap();

        }
    }
}
