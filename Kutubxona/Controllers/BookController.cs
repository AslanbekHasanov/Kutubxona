using Kutubxona.DataLayer;
using Kutubxona.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kutubxona.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BookController : ControllerBase
    {
        private readonly SetDbContext _setDb;

        public BookController(SetDbContext setDb) 
        {
            _setDb = setDb;
        }
        [HttpPost]
        public bool SetUser(User user)
        {
            _setDb.Users.Add(user);
            _setDb.SaveChanges();
            return true;


        }
        [HttpGet]
        public IEnumerable<User> GetAllData()
        {
            return _setDb.Users
                .Include(x => x.UserBook)
                .Include(x => x.UserCar)
                .ToList();
        }
        [HttpPost]
        public bool PostBook([FromForm]Book book)
        {
            _setDb.Books.Add(book);
            _setDb.SaveChanges();
            return true;

        }
        [HttpPost]
        public bool PostCar([FromForm]Car car)
        {
            _setDb.Cars.Add(car);
            _setDb.SaveChanges();
            return true;

        }
        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return _setDb.Books.OrderBy(p => p.Id);

        }
        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return _setDb.Cars.ToList();

        }



    }
}
