using BookAPI.Entities;

namespace BookAPI.ResponseModels
{
    public class BookResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Author { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public string Genre { get; set; } = null!;
        public int Pages { get; set; }
    }
}
