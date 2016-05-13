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
    public class OrdersController : Controller
    {
        private OrderRepository _db = new OrderRepository();

        // GET: Orders
        public ActionResult Index()
        {
            return View(_db.GetOrders());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = _db.GetById(Convert.ToInt32(id));
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(_db.GetOrders(), "StudentId", "Name");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderId,OrderDate,Closed,TotalCharge,StudentId,OderItemId")] Order order)
        {
            if (ModelState.IsValid)
            {
                _db.Insert(order);
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(_db.GetOrders(), "StudentId", "Name", order.StudentId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = _db.GetById(Convert.ToInt32(id));
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(_db.GetOrders(), "StudentId", "Name", order.StudentId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderId,OrderDate,Closed,TotalCharge,StudentId,OderItemId")] Order order)
        {
            if (ModelState.IsValid)
            {
                _db.Update(order);
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(_db.GetOrders(), "StudentId", "Name", order.StudentId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = _db.GetById(Convert.ToInt32(id));
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = _db.GetById(Convert.ToInt32(id));
            _db.Delete(order);
          
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
