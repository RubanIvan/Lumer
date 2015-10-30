using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lumer.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        public ActionResult Index(int? id)
        {
            return View();
        }
    }
}