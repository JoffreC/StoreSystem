using Microsoft.AspNetCore.Mvc;

namespace StoreSystem.WebApplication.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
