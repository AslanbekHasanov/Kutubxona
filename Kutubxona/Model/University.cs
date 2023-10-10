using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Kutubxona.Model
{
    public class University 
    {
        [Identity]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students{ get; set; }

    }
}
