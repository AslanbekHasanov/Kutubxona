using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Kutubxona.Model
{
    public class Book
    {
        [Identity]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Discreption { get; set; }
    }
}
