using Data.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace AgaOrganizationProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : Controller
    {
        private readonly IUnitOfWork _db;

        public CityController(IUnitOfWork db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CityAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CityAdd( City city)
        {
            _db.Cities.Add(city);
            _db.Save();
            return Ok();
        }
        [HttpPost]
        public IActionResult CityDelete(Guid id )
        {
            _db.Cities.Remove(id);
            _db.Save();
            return Ok();
        }
        [HttpGet]
        public IActionResult CityUpdate(Guid id)
        {
            _db.Cities.GetById(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult CityUpdate(City city)
        {
            _db.Cities.Update(city);
            return Ok();
        }

    }
}
