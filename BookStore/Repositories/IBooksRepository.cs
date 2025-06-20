using BookStore.Models;

namespace BookStore.Repositories
{
    public interface IBooksRepository
    {
          Task<BookModel> AddBook(BookModel Book);
          Task<List<BookModel>> GetBooks();
          Task<BookModel> GetBookById(int id);

    }
}
