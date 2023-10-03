using System.ComponentModel.DataAnnotations;

namespace Kutubxona.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Discreption { get; set; }
    }
}
