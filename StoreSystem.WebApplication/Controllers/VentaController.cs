﻿using Microsoft.AspNetCore.Mvc;

namespace StoreSystem.WebApplication.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult NuevaVenta()
        {
            return View();
        }

        public IActionResult HistorialVenta()
        {
            return View();
        }

    }
}
