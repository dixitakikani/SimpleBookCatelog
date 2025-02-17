using SimpleBookCatelog.Domain.Entities;

namespace SimpleBookCatelog.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);

        Task<List<Book>> GetAllAsync();
    }
}
