using BookAPI.Context;
using BookAPI.DTOs;
using BookAPI.Entities;
using BookAPI.Interfaces;
using BookAPI.ResponseModels;
using Dapper;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DapperContext _context;
        public BookRepository(DapperContext context) => _context = context;

        public async Task<IEnumerable<BookResponseModel>> GetAllBooks()
        {
            string query = @"
            SELECT 
                b.*,
                g.name AS Genre,
                a.name AS Author
            FROM 
                Book b
            JOIN 
                Genre g ON b.Genre = g.id
            JOIN 
                Author a ON b.Author = a.id";

            using (var conn = _context.CreateConnection())
            {
                var books = await conn.QueryAsync<BookResponseModel>(query);

                return books.ToList();
            }
        }

        public async Task AddBook(BookDTO book)
        {
            string insertQuery = @"
                INSERT INTO Book (Title, Author, Genre, Pages, Description) 
                VALUES (@Title, @Author, @Genre, @Pages, @Description)";
                

            var parameters = new
            {
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Pages = book.Pages,
                Description = book.Description
            };

            using (var conn = _context.CreateConnection())
            {
                await conn.ExecuteAsync(insertQuery, parameters);
            }
        }

       
    }
}
