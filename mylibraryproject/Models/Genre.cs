namespace mylibraryproject.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Many-to-many relationship with Author
        public ICollection<AuthorGenre> AuthorGenres { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
