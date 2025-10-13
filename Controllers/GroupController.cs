using Microsoft.AspNetCore.Mvc;

namespace EventManagerMVC.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
