using MVCDemo44.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo44.Controllers
{
    public class MovieController : Controller
    {
        MovieDBHandler movieDB = new MovieDBHandler(); 
        // GET: Movie
        public ActionResult Index()
        {
           
            return View(movieDB.GetMovie());
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View(movieDB.GetMovie().Find(m => m.MovieID==id));
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(MovieInfo movieCreate)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    movieDB.AddMovie(movieCreate);   
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View(movieDB.GetMovie().Find(m => m.MovieID == id));
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MovieInfo movieEdit)
        {
            try
            {
                // TODO: Add update logic here
                movieDB.UpdateDetails(movieEdit);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(movieDB.GetMovie().Find(m => m.MovieID == id));
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                if (movieDB.DeleteMovie(id))
                {
                    ViewBag.AlertMsg = "Movie Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
