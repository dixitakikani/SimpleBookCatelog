using Microsoft.EntityFrameworkCore;
using SimpleBookCatelog.Domain.Entities;

namespace SimpleBookCatelog.Infrastructure.Context
{
    public class SimpleBookCatelogDbContext : DbContext
    {
        public SimpleBookCatelogDbContext(DbContextOptions<SimpleBookCatelogDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
