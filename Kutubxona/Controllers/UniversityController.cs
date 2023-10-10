using Kutubxona.DataLayer;
using Kutubxona.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kutubxona.Controllers
{
    //This is controller
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class UniversityController : ControllerBase
    {
        private readonly SetDbContext _setDb;

        public UniversityController(SetDbContext setDb)
        {
            _setDb = setDb;
            
        }
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _setDb.Students.ToList();
        }
        [HttpPost]
        public bool PostUniversity(University university)
        {

            _setDb.Universities.Add(university);
            _setDb.SaveChanges();
            return true;
        }
        [HttpGet("univerName")]
        public IEnumerable<University> GetUniversities(string univerName)
        {
            return _setDb.Universities.Where(p => p.Name == univerName)
                .Include(x => x.Students).ToList();

        }
        [HttpDelete]
        public bool DeleteUniver(int id)
        {
            var res = _setDb.Universities
                    .Include(_ => _.Students)
                    .FirstOrDefault(x => x.Id == id);

            if(res != null) 
            {
                _setDb.Remove(res);
                _setDb.SaveChanges();
                return true;

            
            }
            return false;
        }



    }
}
