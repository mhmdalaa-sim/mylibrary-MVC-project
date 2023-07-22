namespace mylibraryproject.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int year { get; set; }

        // Foreign key for Author entity's primary key
        public int AuthorId { get; set; }

        // Navigation property for the Author entity
        public Author Author { get; set; }

        public Genre Genre { get; set; }
      
    }
}
