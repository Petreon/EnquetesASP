using System.Diagnostics;
using EnquetesASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnquetesASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
