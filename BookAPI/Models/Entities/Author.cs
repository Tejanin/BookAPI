namespace BookAPI.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
