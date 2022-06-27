using FFirstWeaher.Models;
using Microsoft.AspNetCore.Mvc;

namespace FFirstWeaher.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
