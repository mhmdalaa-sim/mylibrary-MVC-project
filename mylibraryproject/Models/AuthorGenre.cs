namespace mylibraryproject.Models
{
    public class AuthorGenre
    {
        // Composite key combining AuthorId and GenreId
        public int AuthorId { get; set; }
        public int GenreId { get; set; }

        // Navigation properties for Author and Genre entities
        public Author Author { get; set; }
        public Genre Genre { get; set; }
    }
}
