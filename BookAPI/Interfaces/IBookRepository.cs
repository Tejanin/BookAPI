using BookAPI.DTOs;
using BookAPI.Entities;
using BookAPI.ResponseModels;

namespace BookAPI.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookResponseModel>> GetAllBooks();

        Task AddBook(BookDTO book);
    }
}
