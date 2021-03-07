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
    public class SinhViensController : Controller
    {
        private QuanlyhocDBEntities db = new QuanlyhocDBEntities();

        // GET: SinhViens
        public ActionResult Index(string ten, string MaKhoa)
        {
            var khoa = from i in db.KhoaDaoTaos select i;
            ViewBag.MaKhoa = new SelectList(khoa, "MaKhoa", "TenKhoa");
            var sinhViens = db.SinhViens.Include(s => s.KhoaDaoTao);
            if (!string.IsNullOrEmpty(ten))
            {
                sinhViens = sinhViens.Where(i => i.HoTen.Contains(ten));
            }
            if (!string.IsNullOrEmpty(MaKhoa))
            {
                sinhViens = sinhViens.Where(i => i.MaKhoa.Contains(MaKhoa));
            }
            return View(sinhViens.ToList());
        }

        // GET: SinhViens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // GET: SinhViens/Create
        public ActionResult Create()
        {
            ViewBag.MaKhoa = new SelectList(db.KhoaDaoTaos, "MaKhoa", "TenKhoa");
            return View();
        }

        // POST: SinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKhoa,LopBC,MaSV,HoTen,NgaySinh,DiaChi")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                db.SinhViens.Add(sinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhoa = new SelectList(db.KhoaDaoTaos, "MaKhoa", "TenKhoa", sinhVien.MaKhoa);
            return View(sinhVien);
        }

        // GET: SinhViens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhoa = new SelectList(db.KhoaDaoTaos, "MaKhoa", "TenKhoa", sinhVien.MaKhoa);
            return View(sinhVien);
        }

        // POST: SinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKhoa,LopBC,MaSV,HoTen,NgaySinh,DiaChi")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhoa = new SelectList(db.KhoaDaoTaos, "MaKhoa", "TenKhoa", sinhVien.MaKhoa);
            return View(sinhVien);
        }

        // GET: SinhViens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // POST: SinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SinhVien sinhVien = db.SinhViens.Find(id);
            db.SinhViens.Remove(sinhVien);
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
