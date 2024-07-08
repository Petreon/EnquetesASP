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

        [HttpGet]
        public IActionResult Responder()
        {
            // Will search for a view called Responder.cshtml
            return View();
        }

        [HttpPost]
        public IActionResult Responder(Resposta userResposta)
        {
            //databiding
            //will receive the object Resposta in form

            Repositorio.AdicionarResposta(userResposta);

            return Content($"Recebemos sua reposta com sucesso: {userResposta.Name}");
        }
    }
}
