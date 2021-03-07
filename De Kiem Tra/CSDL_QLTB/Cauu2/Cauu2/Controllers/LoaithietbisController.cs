using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cauu2.Models;

namespace Cauu2.Controllers
{
    public class LoaithietbisController : Controller
    {
        private QLTBEntities db = new QLTBEntities();

        // GET: Loaithietbis
        public ActionResult Index()
        {
            return View(db.Loaithietbis.ToList());
        }

        // GET: Loaithietbis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loaithietbi loaithietbi = db.Loaithietbis.Find(id);
            if (loaithietbi == null)
            {
                return HttpNotFound();
            }
            return View(loaithietbi);
        }

        // GET: Loaithietbis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Loaithietbis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Maloai,Tenloai,Danhmuc")] Loaithietbi loaithietbi)
        {
            if (ModelState.IsValid)
            {
                db.Loaithietbis.Add(loaithietbi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaithietbi);
        }

        // GET: Loaithietbis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loaithietbi loaithietbi = db.Loaithietbis.Find(id);
            if (loaithietbi == null)
            {
                return HttpNotFound();
            }
            return View(loaithietbi);
        }

        // POST: Loaithietbis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Maloai,Tenloai,Danhmuc")] Loaithietbi loaithietbi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaithietbi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaithietbi);
        }

        // GET: Loaithietbis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loaithietbi loaithietbi = db.Loaithietbis.Find(id);
            if (loaithietbi == null)
            {
                return HttpNotFound();
            }
            return View(loaithietbi);
        }

        // POST: Loaithietbis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Loaithietbi loaithietbi = db.Loaithietbis.Find(id);
            db.Loaithietbis.Remove(loaithietbi);
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
