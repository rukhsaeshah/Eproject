using Microsoft.AspNetCore.Mvc;

namespace Eproject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
