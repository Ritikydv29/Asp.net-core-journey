using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext>options):base(options)
        {

        }
        public DbSet<BookModel>Books { get; set; }
    }
}
