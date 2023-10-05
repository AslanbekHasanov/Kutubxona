using LinqToDB.Mapping;

namespace Kutubxona.Model.ManyToMany
{
    public class Company
    {
        public Company()
        {
            Employee = new List<Employe>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employe> Employee { get; set; }
    }
}
