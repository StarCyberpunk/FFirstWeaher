using FFirstWeaher.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FFirstWeaher.Components
{
    public class WeathersYearMonth:ViewComponent
    {
        private  WeatherRepository repository;
        
        public WeathersYearMonth()
        {
            this.repository = new WeatherRepository(2010,1);
        }
        public IViewComponentResult Invoke(int year,int month)
        {
            var s=GetMonthYearData(year, month);
            if (s == null) {return View();}
            else {
                WeathersYearMonthViewModel result = new WeathersYearMonthViewModel()
                {
                    month = month, year = year, weathersYearMonth = s
            };
            return View(result);
            }
        }
        public List<Weather> GetMonthYearData(int year,int month)
        {
            
            repository = new WeatherRepository(year,month);
            return repository.GetWeathers();
            
        }
    }
}
