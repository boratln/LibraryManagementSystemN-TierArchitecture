using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Dtos.BookDtos;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _BookService;
        private readonly LibraryManagementContext _libraryManagementContext;
        public BookController(IBookService BookService, LibraryManagementContext libraryManagementContext)
        {
            _BookService = BookService;
            _libraryManagementContext = libraryManagementContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _BookService.TGetListAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddBook(CreateBookDto Book)
        {
          
            var addedBook = new Book
            {
             AuthorId = Book.AuthorId,
             Description = Book.Description,
             StockCount = Book.StockCount,
             PageCount = Book.PageCount,
             Title = Book.Title,
             UnitPrice = Book.UnitPrice,
             BookUrl = Book.BookUrl,
             



            };
            _BookService.TAdd(addedBook);
            return Ok("Yazar eklendi");
        }

        [HttpDelete("DeleteBookr/{id}")]
        public IActionResult DeleteBook(int id)
        {

            var Book = _BookService.TGetById(id);
            if (Book != null)
            {
                using (var transaction = _libraryManagementContext.Database.BeginTransaction())
                {
                    try
                    {
                        _BookService.TDelete(Book);
                        transaction.Commit();
                        return Ok("Yazar silme işlemi başarılı");
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return BadRequest("Silme işlemi başarısız");
                    }
                }

            }
            return NotFound("Yazar bulunamadı!");
        }

        [HttpPut("UpdateBook")]
        public IActionResult UpdateBook(UpdateBookDto updateBook)
        {
            var Book = _BookService.TGetById(updateBook.BookId);
            if (Book != null)
            {
           

                Book.BookUrl = updateBook.BookUrl;
                Book.Title = updateBook.Title;
                Book.UnitPrice = updateBook.UnitPrice;
                Book.Description = updateBook.Description;
                Book.AuthorId = updateBook.AuthorId;
                Book.PageCount = updateBook.PageCount;
                Book.StockCount = updateBook.StockCount;

                _BookService.TUpdate(Book);
                return Ok("Yazar güncelleme işlemi başarılı");


            }
            return NotFound("Yazar bulunamadı");

        }
    }
}
