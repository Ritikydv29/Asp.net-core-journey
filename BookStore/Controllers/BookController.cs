using BookStore.Models;
using BookStore.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBooksRepository _booksRepository;
        public BookController(IBooksRepository  booksRepository) { 
            _booksRepository = booksRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var records=await _booksRepository.GetBooks();
            return Ok(records);
        }
        [HttpPost("")]
        public async Task<IActionResult> Insert([FromBody]BookModel bookModel)
        {
            var books = await _booksRepository.AddBook(bookModel);
            return Created($"/api/book/{books.Id}", books);

        }

        [HttpGet("{id}")]
        public async Task<BookModel> GetBookById([FromRoute]int id)
        {
            var record = await _booksRepository.GetBookById(id);
            return record;
        }
    }
}
