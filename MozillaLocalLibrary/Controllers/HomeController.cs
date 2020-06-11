using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MozillaLocalLibrary.Data;
using MozillaLocalLibrary.Models;

namespace MozillaLocalLibrary.Controllers
{
    public class HomeController : Controller
    {   
        private LocalLibraryContext _repository { get; set; }

        public HomeController(LocalLibraryContext context)
        {
            _repository = context;
        }
        public IActionResult Index()
        {
            ViewData["BookCount"] = _repository.Books.AsNoTracking().Count();
            ViewData["Copies"] = _repository.BookInstances.AsNoTracking().Count();
            ViewData["Copies Available"] = _repository.BookInstances
                .AsNoTracking()
                .Where(it => it.Status == LoanStatus.Available)
                .Count();
            ViewData["Authors"] = _repository.Authors.AsNoTracking().Count();
            ViewData["Genres"] = _repository.Genres.AsNoTracking().Count();

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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
