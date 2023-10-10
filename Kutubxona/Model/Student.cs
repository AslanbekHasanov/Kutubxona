using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Kutubxona.Model
{
    public class Student
    {
        [Identity]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Hobbiess { get; set; }
    }
}