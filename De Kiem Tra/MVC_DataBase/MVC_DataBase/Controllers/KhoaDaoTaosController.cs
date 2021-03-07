using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_DataBase.Models;

namespace MVC_DataBase.Controllers
{
    public class KhoaDaoTaosController : Controller
    {
        private QuanlyhocDBEntities db = new QuanlyhocDBEntities();

        // GET: KhoaDaoTaos
        public ActionResult Index(string TenKhoa)
        {
            var khoaDaoTao = from i in db.KhoaDaoTaos select i;
            if (!String.IsNullOrEmpty(TenKhoa))
            {
                khoaDaoTao = khoaDaoTao.Where(i => i.TenKhoa.Contains(TenKhoa));
            }
            return View(khoaDaoTao);
        }

        // GET: KhoaDaoTaos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaDaoTao khoaDaoTao = db.KhoaDaoTaos.Find(id);
            if (khoaDaoTao == null)
            {
                return HttpNotFound();
            }
            return View(khoaDaoTao);
        }

        // GET: KhoaDaoTaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhoaDaoTaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKhoa,TenKhoa,Phone")] KhoaDaoTao khoaDaoTao)
        {
            if (ModelState.IsValid)
            {
                db.KhoaDaoTaos.Add(khoaDaoTao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(khoaDaoTao);
        }

        // GET: KhoaDaoTaos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaDaoTao khoaDaoTao = db.KhoaDaoTaos.Find(id);
            if (khoaDaoTao == null)
            {
                return HttpNotFound();
            }
            return View(khoaDaoTao);
        }

        // POST: KhoaDaoTaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKhoa,TenKhoa,Phone")] KhoaDaoTao khoaDaoTao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khoaDaoTao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khoaDaoTao);
        }

        // GET: KhoaDaoTaos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaDaoTao khoaDaoTao = db.KhoaDaoTaos.Find(id);
            if (khoaDaoTao == null)
            {
                return HttpNotFound();
            }
            return View(khoaDaoTao);
        }

        // POST: KhoaDaoTaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KhoaDaoTao khoaDaoTao = db.KhoaDaoTaos.Find(id);
            db.KhoaDaoTaos.Remove(khoaDaoTao);
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
