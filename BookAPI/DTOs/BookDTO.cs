using BookAPI.Entities;

namespace BookAPI.DTOs
{
    public class BookDTO
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Author { get; set; }
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public int Genre { get; set; }
        public int Pages { get; set; }
    }
}
