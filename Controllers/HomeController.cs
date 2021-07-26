using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleBiodataNetcore.Models;

namespace SimpleBiodataNetcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            ViewData["nama"] = "lamse";
            ViewData["jenisKelamin"] = "Laki-laki";
            ViewData["hobby"] = "musik";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TambahData()
        {
            return View();
        }

        
        //public IHttpActionResult InsertData(BiodataModel biodata)
        //{

        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
