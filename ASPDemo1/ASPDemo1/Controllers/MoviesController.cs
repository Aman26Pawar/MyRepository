using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDemo1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult SearchMovie(string movieName)
        {
            var input = Server.HtmlEncode(movieName);
            return Content(input);
        }
    }
}