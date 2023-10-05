

using Kutubxona.Model.ManyToMany;
using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Kutubxona.Model
{
    public class Car
    {
        [Identity]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

    }
}
