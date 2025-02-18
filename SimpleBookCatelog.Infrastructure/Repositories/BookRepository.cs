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

        public async Task<List<Book>> GetAllAsync()
        {
            var books = await context.Books.ToListAsync();
            return books;
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            var book = await context.Books.FirstOrDefaultAsync(e => e.Id == id);
            return book;
        }

        public Task UpdateAsync(Book book)
        {
            context.Entry(book).State = EntityState.Modified; 
            return context.SaveChangesAsync();
        }
    }
}
