using System.Collections.Generic;

namespace FFirstWeaher.Models
{
    public class WeathersYearMonthViewModel
    {
        public int month { get; set; }
        public int year { get; set; }
        public List<Weather> weathersYearMonth=new List<Weather>();
    }
}
