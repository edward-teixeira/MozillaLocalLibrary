using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MozillaLocalLibrary.Data;
using MozillaLocalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.Controllers
{
    [Route("/catalog/[controller]/[action]")]
    public class BookController: Controller
    {
        private LocalLibraryContext _repository { get; set; }

        public BookController(LocalLibraryContext repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = _repository
                                .BookAuthors
                                .AsNoTracking()
                                .Include(it => it.Book)
                                .Include(it => it.Author)
                                .ToList();


            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ViewData["Genres"] = _repository.Genres.ToList();
                    _repository.Books.Add(book);
                    _repository.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return Redirect("catalog/error");
                }
            }

            return View(book);
        }

        public IActionResult Detail(int? id)
        {
            var book = _repository.Books.Find(id);

            if(book != null)
            {
                return View(book);
            }

            return Redirect("catalog/error");
        }
    }
}
