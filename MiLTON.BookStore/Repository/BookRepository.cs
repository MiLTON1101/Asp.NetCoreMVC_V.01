using MiLTON.BookStore.Models;

namespace MiLTON.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel? GetBookById(int id)
        {
            return DataSource().FirstOrDefault(x => x.Id == id);
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource()
                .Where(x => 
                    (x.Title != null && x.Title.Contains(title)) || 
                    (x.Author != null && x.Author.Contains(authorName)))
                .ToList();
        }
        
        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel { Id = 1, Title = "C# in Depth", Author = "Jon Skeet" },
                new BookModel { Id = 2, Title = "Pro ASP.NET Core MVC", Author = "Adam Freeman" },
                new BookModel { Id = 3, Title = "CLR via C#", Author = "Jeffrey Richter" },
                new BookModel { Id = 4, Title = "Head First C#", Author = "Andrew Stellman" },
                new BookModel { Id = 5, Title = "Clean Code", Author = "Robert C. Martin" }
            };
        }
    }
}
