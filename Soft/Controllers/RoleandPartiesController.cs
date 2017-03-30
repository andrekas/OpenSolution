using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Soft.Models;

namespace Soft.Controllers
{
    public class RoleandPartiesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RoleandParties
        public ActionResult Index()
        {
            return View(db.RoleandParties.ToList());
        }

        // GET: RoleandParties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoleandParty roleandParty = db.RoleandParties.Find(id);
            if (roleandParty == null)
            {
                return HttpNotFound();
            }
            return View(roleandParty);
        }

        // GET: RoleandParties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleandParties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,GivenName,LastName,Gender")] RoleandParty roleandParty)
        {
            if (ModelState.IsValid)
            {
                db.RoleandParties.Add(roleandParty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roleandParty);
        }

        // GET: RoleandParties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoleandParty roleandParty = db.RoleandParties.Find(id);
            if (roleandParty == null)
            {
                return HttpNotFound();
            }
            return View(roleandParty);
        }

        // POST: RoleandParties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,GivenName,LastName,Gender")] RoleandParty roleandParty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roleandParty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roleandParty);
        }

        // GET: RoleandParties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoleandParty roleandParty = db.RoleandParties.Find(id);
            if (roleandParty == null)
            {
                return HttpNotFound();
            }
            return View(roleandParty);
        }

        // POST: RoleandParties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RoleandParty roleandParty = db.RoleandParties.Find(id);
            db.RoleandParties.Remove(roleandParty);
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
