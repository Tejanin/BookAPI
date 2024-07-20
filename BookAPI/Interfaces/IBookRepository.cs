using BookAPI.Models.Entities;
using BookAPI.Models.DTOs;
using BookAPI.Models.ResponseModels;

namespace BookAPI.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookResponseModel>> GetAllBooks();

        Task AddBook(BookDTO book);
    }
}
