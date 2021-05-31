using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.DataContext;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentClassesController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: StudentClasses
        public ActionResult Index()
        {
            var studentObj = db.StudentObj.Include(s => s.groups).Include(s => s.rooms);
            return View(studentObj.ToList());
        }

        // GET: StudentClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentClass studentClass = db.StudentObj.Find(id);
            if (studentClass == null)
            {
                return HttpNotFound();
            }
            return View(studentClass);
        }

        // GET: StudentClasses/Create
        public ActionResult Create()
        {
            ViewBag.group_id = new SelectList(db.Groups, "group_id", "name");
            ViewBag.room_id = new SelectList(db.Rooms, "room_id", "room_id");
            return View();
        }

        // POST: StudentClasses/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SID,firstname,lastname,room_id,group_id")] StudentClass studentClass)
        {
            if (ModelState.IsValid)
            {
                db.StudentObj.Add(studentClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.group_id = new SelectList(db.Groups, "group_id", "name", studentClass.group_id);
            ViewBag.room_id = new SelectList(db.Rooms, "room_id", "room_id", studentClass.room_id);
            return View(studentClass);
        }

        // GET: StudentClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentClass studentClass = db.StudentObj.Find(id);
            if (studentClass == null)
            {
                return HttpNotFound();
            }
            ViewBag.group_id = new SelectList(db.Groups, "group_id", "name", studentClass.group_id);
            ViewBag.room_id = new SelectList(db.Rooms, "room_id", "room_id", studentClass.room_id);
            return View(studentClass);
        }

        // POST: StudentClasses/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SID,firstname,lastname,room_id,group_id")] StudentClass studentClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.group_id = new SelectList(db.Groups, "group_id", "name", studentClass.group_id);
            ViewBag.room_id = new SelectList(db.Rooms, "room_id", "room_id", studentClass.room_id);
            return View(studentClass);
        }

        // GET: StudentClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentClass studentClass = db.StudentObj.Find(id);
            if (studentClass == null)
            {
                return HttpNotFound();
            }
            return View(studentClass);
        }

        // POST: StudentClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentClass studentClass = db.StudentObj.Find(id);
            db.StudentObj.Remove(studentClass);
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
