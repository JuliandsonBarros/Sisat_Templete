using Microsoft.AspNetCore.Mvc;

namespace Sisat_Templete.Controllers
{
    public class ProjetosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details()
        {
            return View();
        }
    }
}
