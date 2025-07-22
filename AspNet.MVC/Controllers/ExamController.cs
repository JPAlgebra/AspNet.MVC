using System.Diagnostics;
using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNET.MVC.Controllers
{
    public class ExamController : Controller
    {
        private static List<Author> _authors;
        private static List<Book> _books;

        private readonly ILogger<ExamController> _logger;

        public ExamController(ILogger<ExamController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (_authors == null)
            {
                _authors =
                [
                    new() {Id = 1, FullName = "John Smith", Nationality = "English"},
                    new() {Id = 2, FullName = "Bruno Kruger", Nationality = "German", PenName = "John Doe"},
                    new() {Id = 3, FullName = "Tony Orwell", Nationality = "American"},
                ];
            }
            if (_books == null)
            {
                _books =
                [
                    new() {Id = 1, Title = "The Clockmaker", YearPublished = 1963, Language = "English (UK)", Author = _authors[0]},
                    new() {Id = 1, Title = "Parliment of Gold", YearPublished = 2017, Language = "English (US)", Author = _authors[2]},
                    new() {Id = 1, Title = "Language of Color", YearPublished = 2007, Language = "German", Author = _authors[1]},
                    new() {Id = 1, Title = "New Pair of Ears", YearPublished = 2025, Language = "English(US)", Author = _authors[2]},
                    new() {Id = 1, Title = "Maestro", YearPublished = 2024, Language = "English (UK)", Author = _authors[0]},
                ];
            }

            return View(_books);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
