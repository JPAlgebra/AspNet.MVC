using System.ComponentModel;

namespace AspNet.MVC.Models
{
    public class Author
    {
        public int Id { get; set; }

        [DisplayName("Full Name")]
        public string FullName { get; set; }

        public string Nationality { get; set; }

        [DisplayName("Pen Name")]
        public string? PenName { get; set; }
    }
}
