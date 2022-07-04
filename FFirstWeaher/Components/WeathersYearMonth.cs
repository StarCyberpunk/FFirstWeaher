using FFirstWeaher.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FFirstWeaher.Components
{
    public class WeathersYearMonth:ViewComponent
    {
        private readonly WeatherRepository repository;
         public WeathersYearMonth()
        {
            this.repository =  new WeatherRepository(new int[] { 2010, 2011, 2012, 2013 });
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
            int countyears = repository.GetWeathers().Count;
            foreach(WeathersForYear weathersss in repository.GetWeathers())
            {
                if (weathersss.year == year)
                {
                    for(int i = 0; i < weathersss.weathersForYear.Count; i++)
                    {
                        if (month == i + 1)
                        {
                           return weathersss.weathersForYear[i];
                            break;
                        }
                    }
                    break;
                }
                
            }
            return null;
        }
    }
}
