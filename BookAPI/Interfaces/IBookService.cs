using BookAPI.Models.Entities;

namespace BookAPI.Interfaces
{
    public interface IBookService
    {
        public Task<Book> AddBook(Book book);

        public Task<Book> UpdateBook(int bookId);

        public Task<Book> DeleteBook(int bookId);

        public Task<Book> GetBookById(int bookId);
        public Task<Book> GetBookByName(string name);

        public Task<IEnumerable<Book>> GetAllBooks();   
    }
}
