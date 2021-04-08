using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        static List<Movies> movies = new List<Movies>()
        {
            new Movies(){Id=1,Name="KHNH",Price=200},
            new Movies(){Id=2,Name="MNIK",Price=300}
        };
        // GET: Movies
        public ActionResult Index()
        {
            return View(movies);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movies m)
        {
            movies.Add(m);
            return View();
        }
        public ActionResult Details(int Id)
        {
            if (String.IsNullOrWhiteSpace(Id.ToString()))
            {
                return RedirectToAction("Index");
            }
            var movie = movies.Find(x => x.Id == Id);
            return View(movie);
        }
    }
}