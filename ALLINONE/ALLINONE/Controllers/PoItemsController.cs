using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ALLINONE.DATA;
using ALLINONE.SERVICE;

namespace ALLINONE.Controllers
{
    public class PoItemsController : Controller
    {
        private PoItemsRepository db = new PoItemsRepository();

        // GET: PoItems
        public ActionResult Index()
        {
            return View(db.GetItems());
        }

        // GET: PoItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoItem poItem = db.GetById(Convert.ToInt32(id));
            if (poItem == null)
            {
                return HttpNotFound();
            }
            return View(poItem);
        }

        // GET: PoItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PoItemId,Name,Unitprice")] PoItem poItem)
        {
            if (ModelState.IsValid)
            {
                db.Insert(poItem);
                return RedirectToAction("Index");
            }

            return View(poItem);
        }

        // GET: PoItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoItem poItem = db.GetById(Convert.ToInt32(id));
            if (poItem == null)
            {
                return HttpNotFound();
            }
            return View(poItem);
        }

        // POST: PoItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PoItemId,Name,Unitprice")] PoItem poItem)
        {
            if (ModelState.IsValid)
            {
                db.Update(poItem);
                return RedirectToAction("Index");
            }
            return View(poItem);
        }

        // GET: PoItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoItem poItem = db.GetById(Convert.ToInt32(id));
            if (poItem == null)
            {
                return HttpNotFound();
            }
            return View(poItem);
        }

        // POST: PoItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PoItem poItem = db.GetById(Convert.ToInt32(id));
            db.Delete(poItem);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
              //  db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
