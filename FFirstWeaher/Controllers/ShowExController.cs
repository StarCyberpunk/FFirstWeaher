using Microsoft.AspNetCore.Mvc;
using FFirstWeaher.Models;


namespace FFirstWeaher.Controllers
{
    public class ShowExController : Controller
    {
        public IActionResult Show()
        { 
           
            return View();
        }
        public IActionResult ShowNew(int year,int month) { WeathersYearMonthViewModel W = new WeathersYearMonthViewModel(); W.month = month;W.year = year;   return View(W); }
        
    }
}
