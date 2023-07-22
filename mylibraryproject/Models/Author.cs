namespace mylibraryproject.Models
{
    public class Author
    {

        public int Id { get; set; }
        public string Name { get; set; }

        // One-to-many relationship with Book

        public ICollection<Book> Books { get; set; }


        public ICollection<AuthorGenre> AuthorGenres { get; set; }




    }
}
