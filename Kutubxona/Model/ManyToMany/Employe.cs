using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Kutubxona.Model.ManyToMany
{
    public class Employe
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
