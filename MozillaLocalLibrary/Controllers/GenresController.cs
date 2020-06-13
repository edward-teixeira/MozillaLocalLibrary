using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MozillaLocalLibrary.Data;
using MozillaLocalLibrary.Models;
using MozillaLocalLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozillaLocalLibrary.Controllers
{
    [Route("catalog/[controller]/[action]")]
    public class GenresController: Controller
    {
        private LocalLibraryContext _repository { get; set; }

        public GenresController(LocalLibraryContext ctx)
        {
            _repository = ctx;
        }
        public IActionResult Index()
        {
            try
            {
                var genres = _repository.Genres
                                        .OrderBy(it => it.Nome)
                                        .ToList();

                return View("Index", genres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return Redirect("catalog/error");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(GenresViewModel genre)
        {   
            if (ModelState.IsValid)
            {
                try
                {
                    var g = new Genre
                    {
                        Nome = genre.Nome
                    };

                    if(genre.Book != null)
                    {
                        g.Books = new List<Book>();
                        g.Books.Add(genre.Book);
                    }

                    _repository.Genres.Add(g);
                    _repository.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return RedirectPermanent("catalog/error");
                }
            }

            return View(genre);
        }

        public IActionResult Detail(int id)
        {
            var genre = _repository.Genres.Include(it => it.Books).First();
            
            if(genre != null)
            {
                var viewModel = new GenreDetailViewModel {
                    GenreId = genre.GenreId,
                    Books = genre.Books,
                    GenreName = genre.Nome
                };

                return View(viewModel);
            }
            else
            {
                return Redirect("catalog/error");
            }
        }
    }
}
