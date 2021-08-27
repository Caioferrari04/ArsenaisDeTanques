using ArsenalDeTanques.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArsenalDeTanques.Controllers
{
    public class HomeController : Controller
    {
        ICrudService service;
        public HomeController(ICrudService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View(service.GetDestaques(service.GetAll()));
        }
    }
}
