using Microsoft.EntityFrameworkCore;

namespace mylibraryproject.Models.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<AuthorGenre> AuthorGenres { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

     

            modelBuilder.Entity<AuthorGenre>()
                .HasKey(ag => new { ag.AuthorId, ag.GenreId });

            modelBuilder.Entity<AuthorGenre>()
                .HasOne(ag => ag.Author)
                .WithMany(a => a.AuthorGenres)
                .HasForeignKey(ag => ag.AuthorId);

            modelBuilder.Entity<AuthorGenre>()
                .HasOne(ag => ag.Genre)
                .WithMany(g => g.AuthorGenres)
                .HasForeignKey(ag => ag.GenreId);
        }
    }

}

