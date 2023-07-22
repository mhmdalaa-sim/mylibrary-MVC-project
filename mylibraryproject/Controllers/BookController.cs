using Microsoft.AspNetCore.Mvc;
using mylibraryproject.filters;
using mylibraryproject.Models;
using mylibraryproject.Models.Repos;
using NuGet.Protocol.Core.Types;

namespace mylibraryproject.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        [ServiceFilter(typeof(CustomActionFilter))]
        public IActionResult Index(string searchString, int? year, int page = 1)
        {
            ViewBag.SearchString = searchString;
            ViewBag.year = year;

            var books = from b in _bookRepository.GetAllBooks()
                        select b;

            if (!string.IsNullOrEmpty(searchString))
            {
                books = books.Where(b => b.Title.Contains(searchString) || b.Author.Name.Contains(searchString));
            }

            if (year != null && year.HasValue)
            {
                books = books.Where(b => b.year == year);
            }

            var pageSize = 5;
            var totalBooks = books.Count();
            var totalPages = (int)Math.Ceiling((double)totalBooks / pageSize);
            var pagedBooks = books.Skip((page - 1) * pageSize).Take(pageSize);

            ViewBag.Page = page;
            ViewBag.TotalPages = totalPages;

            HttpContext.Session.SetString("UserName", "Mohamed");

            // Retrieve a value from the session
            var userName = HttpContext.Session.GetString("UserName");


            ViewBag.userName = userName;

            return View(pagedBooks);

           
        }

        [HttpPost]

        public ActionResult AddBook(Book book) {

            if (ModelState.IsValid)
            {
                _bookRepository.AddBook(book);
                return RedirectToAction("Index");
            }
            return View(book);

        }


        [HttpGet]
        public IActionResult UpdateBook(int id)
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        
        [HttpPost]
        public IActionResult UpdateBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.UpdateBook(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }


        [HttpGet]
        public IActionResult DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
            return RedirectToAction("Index");
        }




    }
}
