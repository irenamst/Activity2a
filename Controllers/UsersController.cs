using Microsoft.AspNetCore.Mvc;

namespace Activity2a.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Message()
        {
            return View("Message");
        }
        public IActionResult Welcome(string name,int secretNumber = 13)
        {
            ViewBag.UserName = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
