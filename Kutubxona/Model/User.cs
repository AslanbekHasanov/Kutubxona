using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Kutubxona.Model
{
    public class User
    {
        [Identity]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public virtual Book UserBook { get; set; }
        public virtual Car UserCar { get; set; }
    }
}
