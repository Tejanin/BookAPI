using BookAPI.Context;
using BookAPI.Interfaces;

namespace BookAPI.Repositories
{
    public class GenreRepository: IGenreRepository
    {
        private readonly DapperContext _context;

        public GenreRepository(DapperContext context) => _context = context; 
    }
}
