using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Soft.Models;

namespace Soft.Controllers
{
    public class SampleClassesController : Controller
    {
        private SoftContext db = new SoftContext();

        // GET: SampleClasses
        public ActionResult Index()
        {
            return View(db.SampleClasses.ToList());
        }

        // GET: SampleClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SampleClass sampleClass = db.SampleClasses.Find(id);
            if (sampleClass == null)
            {
                return HttpNotFound();
            }
            return View(sampleClass);
        }

        // GET: SampleClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SampleClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,personName,Address,phoneNumber")] SampleClass sampleClass)
        {
            if (ModelState.IsValid)
            {
                db.SampleClasses.Add(sampleClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sampleClass);
        }

        // GET: SampleClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SampleClass sampleClass = db.SampleClasses.Find(id);
            if (sampleClass == null)
            {
                return HttpNotFound();
            }
            return View(sampleClass);
        }

        // POST: SampleClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,personName,Address,phoneNumber")] SampleClass sampleClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sampleClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sampleClass);
        }

        // GET: SampleClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SampleClass sampleClass = db.SampleClasses.Find(id);
            if (sampleClass == null)
            {
                return HttpNotFound();
            }
            return View(sampleClass);
        }

        // POST: SampleClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SampleClass sampleClass = db.SampleClasses.Find(id);
            db.SampleClasses.Remove(sampleClass);
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
