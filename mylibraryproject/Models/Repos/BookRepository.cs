using Microsoft.EntityFrameworkCore;
using mylibraryproject.Models.Data;

namespace mylibraryproject.Models.Repos
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context) {
            _context = context;
        }

        public void AddBook(Book book)
        {

            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.Include(book => book.Genre)
                       .Include(book => book.Author)
                       .ToList();
        }

        public Book GetBookById(int id)
        {
           return _context.Books.First(book => book.Id == id);
        }

        public IEnumerable<Book> SearchBooks(string searchString ,int? year)
        {
            return _context.Books
     .Include(b => b.Author)
     .Include(b => b.Genre)
     .Where(b =>
         (string.IsNullOrEmpty(searchString)
             || b.Title.Contains(searchString)
             || b.Author.Name.Contains(searchString)
             || b.Genre.Name.Contains(searchString))
             && (!year.HasValue || b.year == year.Value))
            .ToList();

        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }
    }
}
