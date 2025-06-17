using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BookStoreContext _context;
        public BooksRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<BookModel> AddBook(BookModel Book)
        {
               _context.Books.Add(Book);
               await _context.SaveChangesAsync();
               return Book;

        }

        public async Task<List<BookModel>> GetBooks()
        {
            var records=await _context.Books.Select(x=>new BookModel()
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
            }).ToListAsync();
            return records;
        }
        public async Task<BookModel> GetBookById(int id)
        {
            var record = await _context.Books.FindAsync(id);

            return record;
        }
    }
}
