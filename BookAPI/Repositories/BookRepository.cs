using BookAPI.Context;
using BookAPI.Interfaces;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DapperContext _context;
        public BookRepository(DapperContext context) => _context = context;


    }
}
