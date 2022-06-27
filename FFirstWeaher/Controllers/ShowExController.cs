using Microsoft.AspNetCore.Mvc;
using FFirstWeaher.Models;

namespace FFirstWeaher.Controllers
{
    public class ShowExController : Controller
    {
        public IActionResult Show(int year,int month)
        { 
            Weathers k=new Weathers {year=year,month=month };
          var z = k.GetDataFromExcel(string.Format(@"C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\DataWeather\moskva_{0}.xlsx",year),month,year);
            return View(k);
        }
        
    }
}
