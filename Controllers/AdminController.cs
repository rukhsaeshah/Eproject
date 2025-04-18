using Eproject.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eproject.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly SignInManager<EprojectUser> _signInManager;
        private readonly UserManager<EprojectUser> _userManager;

        public AdminController(SignInManager<EprojectUser> signInManager, UserManager<EprojectUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
