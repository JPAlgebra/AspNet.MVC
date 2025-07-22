using System.ComponentModel;

namespace AspNet.MVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [DisplayName("Year Published")]
        public int YearPublished { get; set; }

        public string Language { get; set; }

        public Author Author { get; set; }
    }
}
