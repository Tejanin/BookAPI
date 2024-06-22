using BookAPI.Context;
using BookAPI.Interfaces;

namespace BookAPI.Repositories
{
    public class AuthorRepository: IAuthorRepository
    {
        private readonly DapperContext _context;

        public AuthorRepository(DapperContext context) => _context = context;
        
    }
}
