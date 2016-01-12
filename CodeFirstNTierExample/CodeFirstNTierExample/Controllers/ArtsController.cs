using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Database;
using Models;

namespace CodeFirstNTierExample.Controllers
{
    public class ArtsController : Controller
    {
        private CFDbContext db = new CFDbContext();

        // GET: Arts
        public ActionResult Index()
        {
            var arts = db.Arts.Include(a => a.UploadedBy);
            return View(arts.ToList());
        }

        // GET: Arts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Art art = db.Arts.Find(id);
            if (art == null)
            {
                return HttpNotFound();
            }
            return View(art);
        }

        // GET: Arts/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "ID", "Name");
            return View();
        }

        // POST: Arts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Detail,Image,UserId")] Art art, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                byte[] buf = new byte[ImageFile.ContentLength];
                ImageFile.InputStream.Read(buf, 0, buf.Length);
                art.Image = buf;

                db.Arts.Add(art);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "ID", "Name", art.UserId);
            return View(art);
        }

        // GET: Arts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Art art = db.Arts.Find(id);
            if (art == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "ID", "Name", art.UserId);
            return View(art);
        }

        // POST: Arts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Detail,Image,UserId")] Art art)
        {
            if (ModelState.IsValid)
            {
                db.Entry(art).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "ID", "Name", art.UserId);
            return View(art);
        }

        // GET: Arts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Art art = db.Arts.Find(id);
            if (art == null)
            {
                return HttpNotFound();
            }
            return View(art);
        }

        // POST: Arts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Art art = db.Arts.Find(id);
            db.Arts.Remove(art);
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
