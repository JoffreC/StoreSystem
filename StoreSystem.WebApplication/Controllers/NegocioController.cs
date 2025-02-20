using Microsoft.AspNetCore.Mvc;

namespace StoreSystem.WebApplication.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
