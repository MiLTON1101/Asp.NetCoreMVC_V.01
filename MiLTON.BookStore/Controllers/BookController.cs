using Microsoft.AspNetCore.Mvc;
using MiLTON.BookStore.Models;
using MiLTON.BookStore.Repository;

namespace MiLTON.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            //var data = _bookRepository.GetAllBooks();

            return View();
        }

        public BookModel? GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}