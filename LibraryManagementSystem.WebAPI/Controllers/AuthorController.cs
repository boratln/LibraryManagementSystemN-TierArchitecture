using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Dtos.AuthorDtos;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly LibraryManagementContext _libraryManagementContext;
        public AuthorController(IAuthorService authorService, LibraryManagementContext libraryManagementContext)
        {
            _authorService = authorService;
            _libraryManagementContext = libraryManagementContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _authorService.TGetListAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddAuthor([FromForm] CreateAuthorDto author)
        {
            if (author.AuthorImageFile != null && author.AuthorImageFile.Length > 0)
            {

                using (MemoryStream stream = new MemoryStream())
                {

                    author.AuthorImageFile.CopyTo(stream);
                    byte[] imageBytes = stream.ToArray();


                    author.AuthorImageBase64 = Convert.ToBase64String(imageBytes);

                }
            }
            var addedauthor = new Author
            {
                Age = author.Age,
                AuthorImageBase64 = author.AuthorImageBase64,
                Name = author.Name,
                ShortDesc = author.ShortDesc,
                Surname = author.Surname,



            };
            _authorService.TAdd(addedauthor);
            return Ok("Yazar eklendi");
        }

        [HttpDelete("DeleteAuthorr/{id}")]
        public IActionResult DeleteAuthor(int id)
        {

            var author = _authorService.TGetById(id);
            if (author != null)
            {
                using (var transaction = _libraryManagementContext.Database.BeginTransaction())
                {
                    try
                    {
                        _authorService.TDelete(author);
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

        [HttpPut("UpdateAuthor")]
        public IActionResult UpdateAuthor(UpdateAuthorDto updateauthor)
        {
            var author = _authorService.TGetById(updateauthor.AuthorId);
            if (author != null)
            {
                if (updateauthor.AuthorImageFile != null && updateauthor.AuthorImageFile.Length > 0)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        updateauthor.AuthorImageFile.CopyTo(stream);
                        byte[] imageBytes = stream.ToArray();
                        updateauthor.AuthorImageBase64 = Convert.ToBase64String(imageBytes);
                    }
                }

                author.ShortDesc = updateauthor.ShortDesc;
                author.AuthorImageBase64 = updateauthor.AuthorImageBase64;
                author.Surname = updateauthor.Surname;
                author.Name = updateauthor.Name;
                author.Age = updateauthor.Age;
                _authorService.TUpdate(author);
                return Ok("Yazar güncelleme işlemi başarılı");


            }
            return NotFound("Yazar bulunamadı");

        }
    }
}
