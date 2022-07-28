using FFirstWeaher.App_Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace FFirstWeaher.Controllers
{
    public class AddExController : Controller
    {
        
        IWebHostEnvironment _appEnvironment;
        public IActionResult Add()
        {
            return View();
        }
        public AddExController( IWebHostEnvironment appEnvironment)
        {
            
            _appEnvironment = appEnvironment;
        }
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "DataWeather/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                FFirstWeaher.Models.WeatherRepository.UpdateDataFromExcel(path);
            }

            return RedirectToAction("Add");
        }
    }
}
