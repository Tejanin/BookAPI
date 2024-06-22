using BookAPI.Context;
using BookAPI.Interfaces;
using BookAPI.Repositories;
using BookAPI.Services;

namespace BookAPI.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DapperContext _context;
        public UnitOfWork(DapperContext context) 
        { 
            _context = context;
            Books = new BookRepository(context);
            Authors= new AuthorRepository(context);
            Genres = new GenreRepository(context);
            
            
        }

        public IBookRepository Books {  get; private set; }

        public IGenreRepository Genres { get; private set; }

        public IAuthorRepository Authors { get; private set; }
    }
}
