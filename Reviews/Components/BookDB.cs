using Microsoft.EntityFrameworkCore;

namespace Reviews.Components
{
    internal class BookDB : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public BookDB()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@" Data Source = BOOK.db");
        }
    }
}
