using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace velour.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult Shows()
        {
            List<SelectListItem> shows = new List<SelectListItem>();
            shows.Add(new SelectListItem { Text = "James The Mormon", Value = "0" });
            shows.Add(new SelectListItem { Text = "Neon Trees", Value = "1" });
            shows.Add(new SelectListItem { Text = "Imagine Dragons", Value = "2", Selected = true });
            ViewBag.ShowNames = shows;

            return View();
        }

        public ViewResult ShowDetails(string ShowNames)
        {
            if (ShowNames == "0"){
                ViewBag.Artist = "James The Mormon";
                ViewBag.Genre = "Hip-Hop/Rap";
                ViewBag.Website = "http://www.jamesthemormon.com/";
                ViewBag.StartTime = "Nov. 5th 7:00PM";
                ViewBag.Image = "James.jpg";
            }
            else if (ShowNames == "1")
            {
                ViewBag.Artist = "Neon Trees";
                ViewBag.Genre = "Indie";
                ViewBag.Website = "http://www.fameisdead.com/";
                ViewBag.StartTime = "Nov. 12th 7:00PM";
                ViewBag.Image = "Neon.jpg";
            }
            else if (ShowNames == "2")
            {
                ViewBag.Artist = "Imagine Dragons";
                ViewBag.Genre = "Indie";
                ViewBag.Website = "https://www.imaginedragonsmusic.com/";
                ViewBag.StartTime = "Nov. 19th 7:00PM";
                ViewBag.Image = "Imagine.jpg";
            }

            return View("ShowDetails");
        }
    }
}