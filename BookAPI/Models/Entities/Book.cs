namespace BookAPI.Models.Entities
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Author { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public Author IdAuthorNavigation { get; set; } = null!;
        public int Genre { get; set; }
        public Genre IdGenreNavigation { get; set; } = null!;
        public int Pages { get; set; }
    }
}
