using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCController.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult SearchMovie(string movieName)
        {
            var mName = Server.HtmlEncode(movieName);
            return Content(mName);
        }
    }
}