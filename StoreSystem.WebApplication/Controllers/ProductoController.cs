using Microsoft.AspNetCore.Mvc;

namespace StoreSystem.WebApplication.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
