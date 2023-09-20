using Microsoft.AspNetCore.Mvc;

namespace TinderDog.WebApp.Controllers
{
    public class AutenticacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
