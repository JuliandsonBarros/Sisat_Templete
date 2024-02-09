using Microsoft.AspNetCore.Mvc;

namespace Sisat_Templete.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
