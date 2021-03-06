﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieWebApplication.Models;

namespace MovieWebApplication.Controllers
{
    public class MovieController : Controller
    {    
        private moviesEntities3 movieDB = new moviesEntities3();

        // GET: Movie
        public ActionResult Index()
        {
            return View(movieDB.MovieInfoes.ToList());
        }

        // GET: Movie/Details/5
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

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieID,MovieName,Theatre,Rate,ReleaseDate")] MovieInfo movieInfo)
        {
            if (ModelState.IsValid)
            {
                movieDB.MovieInfoes.Add(movieInfo);
                movieDB.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieInfo);
        }

        // GET: Movie/Edit/5
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

        // POST: Movie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieID,MovieName,Theatre,Rate,ReleaseDate")] MovieInfo movieInfo)
        {
            if (ModelState.IsValid)
            {
                movieDB.Entry(movieInfo).State = EntityState.Modified;
                movieDB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieInfo);
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int? id)
        {
            MovieInfo movieInfo = movieDB.MovieInfoes.Find(id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (movieInfo == null)
            {
                return HttpNotFound();
            }
            return View(movieInfo);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieInfo movieInfo = movieDB.MovieInfoes.Find(id);
            movieDB.MovieInfoes.Remove(movieInfo);
            movieDB.SaveChanges();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        movieDB.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //GET:Movie/BookTicket
        //public ActionResult BookTicket(decimal? rate)
        //{
        //    MovieInfo bookTicket = movieDB.MovieInfoes.Find(rate);
        //    if (bookTicket == null)
        //    {
        //        return HttpNotFound(); 
        //    }
        //    return View(bookTicket);
        //}

        ////HttpPost  Movie/BookTicket
        //[HttpPost]
        //public ActionResult BookTicket()
        //{

        //}
    }
}
