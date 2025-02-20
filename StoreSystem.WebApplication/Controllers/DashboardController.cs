using Microsoft.AspNetCore.Mvc;

namespace StoreSystem.WebApplication.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
