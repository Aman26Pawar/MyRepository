using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesMVC;
using System.Net;
using MoviesMVC.Models;
using System.Data.Entity;

namespace MoviesMVC.Controllers
{
    public class MoviesController : Controller
    {
        private moviesDBEntities movieDB = new moviesDBEntities();
        // GET: Movies
        public ActionResult Index()
        {
            //var movieInfo = movieDB.MovieInfoes.Include(m => m.MovieInfo);
            return View(movieDB.MovieInfoes.ToList());
        }

        //GET:Movies/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieInfo movieInfo = movieDB.MovieInfoes.Find(id);
            if (movieInfo == null)
            {
                return HttpNotFound();
            }
            return View(movieInfo);
        }

        //GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST:  Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieID,MovieName,Theatre,Rate")] MovieInfo moviesInfo)
        {
            if (ModelState.IsValid)
            {
                movieDB.MovieInfoes.Add(moviesInfo);
                movieDB.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(moviesInfo);
        }

        //GET: Movies/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieInfo movieInfo = movieDB.MovieInfoes.Find(id);
            if (movieInfo == null)
            {
                return HttpNotFound();
            }
            return View(movieInfo);
        }

        //POST: Movies/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieID,MovieName,Theatre,Rate")] MovieInfo movieInfo)
        {
            if (ModelState.IsValid)
            {
               // movieDB.MovieInfoes.Add(movieInfo);
                movieDB.Entry(movieInfo).State = EntityState.Modified;
                movieDB.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieInfo);
        }

        //GET: Movies/Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MovieInfo movieInfo = movieDB.MovieInfoes.Find(id);
            if (movieInfo == null)
            {
                return HttpNotFound();
            }
            return View(movieInfo);
        }

        // POST: EmployeeDatas/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieInfo movieInfo = movieDB.MovieInfoes.Find(id);
            movieDB.MovieInfoes.Remove(movieInfo);
            movieDB.SaveChanges();
            return RedirectToAction("Index");
        }
            

    }
}