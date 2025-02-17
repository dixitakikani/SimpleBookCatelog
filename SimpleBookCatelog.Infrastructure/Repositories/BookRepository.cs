using Microsoft.EntityFrameworkCore;
using SimpleBookCatelog.Application.Interfaces;
using SimpleBookCatelog.Domain.Entities;
using SimpleBookCatelog.Infrastructure.Context;

namespace SimpleBookCatelog.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly SimpleBookCatelogDbContext context;
        public BookRepository(IDbContextFactory<SimpleBookCatelogDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddAsync(Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();
        }
    }
}
