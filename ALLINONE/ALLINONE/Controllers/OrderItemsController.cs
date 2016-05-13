using System;
using System.Net;
using System.Web.Mvc;
using ALLINONE.DATA;
using ALLINONE.SERVICE;

namespace ALLINONE.Controllers
{
    public class OrderItemsController : Controller
    {
        private OrderItemRepository _db = new OrderItemRepository();

        // GET: OrderItems
        public ActionResult Index()
        {

            return View(_db.GetOrderItems());
        }

        // GET: OrderItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderItem orderItem = _db.GetById(Convert.ToInt32(id));
            if (orderItem == null)
            {
                return HttpNotFound();
            }
            return View(orderItem);
        }

        // GET: OrderItems/Create
        public ActionResult Create()
        {
            ViewBag.ItemId = new SelectList(_db.GetOrderItems(), "ItemId", "Desc");
            ViewBag.OrderId = new SelectList(_db.GetOrderItems(), "OrderId", "OrderId");
            return View();
        }

        // POST: OrderItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderItemId,Qty,OrderId,ItemId")] OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                _db.Insert(orderItem);
                return RedirectToAction("Index");
            }

            ViewBag.ItemId = new SelectList(_db.GetOrderItems(), "ItemId", "Desc", orderItem.ItemId);
            ViewBag.OrderId = new SelectList(_db.GetOrderItems(), "OrderId", "OrderId", orderItem.OrderId);
            return View(orderItem);
        }

        // GET: OrderItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderItem orderItem = _db.GetById(Convert.ToInt32(id));
            if (orderItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.ItemId = new SelectList(_db.GetOrderItems(), "ItemId", "Desc", orderItem.ItemId);
            ViewBag.OrderId = new SelectList(_db.GetOrderItems(), "OrderId", "OrderId", orderItem.OrderId);
            return View(orderItem);
        }

        // POST: OrderItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderItemId,Qty,OrderId,ItemId")] OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                _db.Update(orderItem);
                return RedirectToAction("Index");
            }
            ViewBag.ItemId = new SelectList(_db.GetOrderItems(), "ItemId", "Desc", orderItem.ItemId);
            ViewBag.OrderId = new SelectList(_db.GetOrderItems(), "OrderId", "OrderId", orderItem.OrderId);
            return View(orderItem);
        }

        // GET: OrderItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderItem orderItem = _db.GetById(Convert.ToInt32(id));
            if (orderItem == null)
            {
                return HttpNotFound();
            }
            return View(orderItem);
        }

        // POST: OrderItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderItem orderItem = _db.GetById(Convert.ToInt32(id));
            _db.Delete(orderItem);
           
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               // db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
