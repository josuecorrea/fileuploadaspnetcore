using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace UploadFileExample.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _enviroment;

        public HomeController(IHostingEnvironment enviroment)
        {
            _enviroment = enviroment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult UploadFiles()
        {
            return View();
        }

        [Route("Upload")]
        public IActionResult Upload(IFormFile file)
        {
            return View();
        }
    }
}
