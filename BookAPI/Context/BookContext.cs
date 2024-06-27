using BookAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Context
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
       
        public DbSet<Book> Book { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Author> Author { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(entity => entity.Id);

                entity.Property(entity => entity.Name)
                .IsRequired()
                .HasMaxLength(40);

                entity.Property(entity => entity.Sex)
                .IsRequired()
                .HasMaxLength(10);

                entity.Property(entity => entity.BirthDate)
                .IsRequired();



            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(entity => entity.Id);

                entity.Property(entity => entity.Name)
                .IsRequired()
                .HasMaxLength(40);
            });


            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(entity => entity.Id);

                entity.Property(entity => entity.CreatedAt)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

                entity.Property(entity => entity.IsDeleted)
                .HasDefaultValue(false);




                entity.Property(entity => entity.Title)
                .IsRequired()
                .HasMaxLength(60);

                entity.Property(entity => entity.Author)
                .IsRequired()
                .HasMaxLength(60);

                entity.Property(entity => entity.Description)
                .HasMaxLength(500)
                .IsRequired();

                entity.HasOne(entity => entity.IdGenreNavigation)
                .WithMany(g => g.Books)
                .HasForeignKey(b => b.Genre)
                .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(entity => entity.IdAuthorNavigation)
                .WithMany(g => g.Books)
                .HasForeignKey(b => b.Author)
                .OnDelete(DeleteBehavior.Cascade);

                entity.Property(entity => entity.Pages)
                .IsRequired();
            }
            );
        }
    }
}
