using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogExample.Model;
using Microsoft.Extensions.Options;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogExample.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppSettingsModel _appSettings;

        public BlogController(IOptions<AppSettingsModel> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            string title = _appSettings.Title;
            string imagePath = _appSettings.ImagePath;

            ViewData["Title"] = title;
            ViewData["ImagePath"] = imagePath;

            return View();
        }
    }
}
