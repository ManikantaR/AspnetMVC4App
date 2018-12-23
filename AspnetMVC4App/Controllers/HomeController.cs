using AspnetMVC4App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMVC4App.Controllers
{
    public class HomeController : Controller
    {
        MVC4AppDb db = new MVC4AppDb();
        public ActionResult Index(string searchByName = null)
        {
            var model = db.Restaurants.Where(a => searchByName == null || a.Name.StartsWith(searchByName))
                         .Select(r => new ReviewViewModel()
                         {
                             Id = r.Id,
                             Name = r.Name,
                             Country = r.Country,
                             City = r.City,
                             CountOfReviews = r.Reviews.Count
                         });



            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (db != null)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}