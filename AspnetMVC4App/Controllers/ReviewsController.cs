using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspnetMVC4App.Models;

namespace AspnetMVC4App.Controllers
{
    public class ReviewsController : Controller
    {
        private MVC4AppDb db = new MVC4AppDb();

        // GET: Reviews
        public ActionResult Index()
        {
            return View(db.ReviewViewModels.ToList());
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewViewModel reviewViewModel = db.ReviewViewModels.Find(id);
            if (reviewViewModel == null)
            {
                return HttpNotFound();
            }
            return View(reviewViewModel);
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,City,Country,CountOfReviews")] ReviewViewModel reviewViewModel)
        {
            if (ModelState.IsValid)
            {
                db.ReviewViewModels.Add(reviewViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reviewViewModel);
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewViewModel reviewViewModel = db.ReviewViewModels.Find(id);
            if (reviewViewModel == null)
            {
                return HttpNotFound();
            }
            return View(reviewViewModel);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,City,Country,CountOfReviews")] ReviewViewModel reviewViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reviewViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reviewViewModel);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewViewModel reviewViewModel = db.ReviewViewModels.Find(id);
            if (reviewViewModel == null)
            {
                return HttpNotFound();
            }
            return View(reviewViewModel);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReviewViewModel reviewViewModel = db.ReviewViewModels.Find(id);
            db.ReviewViewModels.Remove(reviewViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
