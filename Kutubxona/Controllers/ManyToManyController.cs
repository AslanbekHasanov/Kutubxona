using Kutubxona.DataLayer;
using Kutubxona.Model;
using Kutubxona.Model.ManyToMany;
using Microsoft.AspNetCore.Mvc;

namespace Kutubxona.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ManyToManyController : Controller
    {
        private readonly SetDbContext _setDb;

        public ManyToManyController(SetDbContext setDb)
        {
            _setDb = setDb;
        }
        [HttpGet]
        public IEnumerable<Employe> GetEmploye()
        {
            return _setDb.Employes.ToList();
        }
        [HttpPost]
        public bool PostEmploye(Employe employe)
        {

            _setDb.Employes.Add(employe);
            _setDb.SaveChanges();
            return true;
        }
        [HttpPost]
        public bool PostCompany (Company company)
        {

            _setDb.Companies.Add(company)
                ;
            _setDb.SaveChanges();
            return true;
        }

    }
}
