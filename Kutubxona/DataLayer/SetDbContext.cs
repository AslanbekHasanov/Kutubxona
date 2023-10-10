using Kutubxona.Model;
using Kutubxona.Model.ManyToMany;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace Kutubxona.DataLayer
{
    public class SetDbContext : DbContext
    {
        public SetDbContext(DbContextOptions<SetDbContext> options)
        : base(options)
        {

            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employe> Employes { get; set; } = null;
        public DbSet<Company> Companies { get; set; }



    }
}
