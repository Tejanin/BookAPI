namespace BookAPI.Models.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Book>? Books { get; set; }
    }
}
