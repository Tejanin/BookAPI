using BookAPI.Interfaces;

namespace BookAPI.UnitOfWork
{
    public interface IUnitOfWork
    {

        IBookRepository Books { get; }
        IGenreRepository Genres { get; }
        IAuthorRepository Authors { get; }
    }
}
