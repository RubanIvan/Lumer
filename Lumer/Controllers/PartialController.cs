using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lumer.Models;

namespace Lumer.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult Carousel()
        {
            
            LumerEntities enties =new LumerEntities();
            var Films = enties.GetFilmOnWeek(GlobalData.WeakStart, GlobalData.WeekEnd);

            List<CarouselModel> model = new List<CarouselModel>();
            foreach (GetFilmOnWeek_Result film in Films)
            {
                CarouselModel carousel =new CarouselModel();
                carousel.FileName = film.PosterName;
                carousel.FilmId = film.FilmId;
                carousel.Title = film.Name;
                model.Add(carousel);
            }

            return PartialView(model);
        }
    }
}