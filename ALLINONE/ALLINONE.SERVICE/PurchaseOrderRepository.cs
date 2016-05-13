using System.Collections.Generic;
using System.Linq;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        ProjectContex _context = new ProjectContex();

        public PurchaseOrder GetById(int id)
        {
            var result = (from r in _context.PurchaseOrders
                          where r.PoId == id
                          select r).FirstOrDefault();
            return result;
        }

        public void Insert(PurchaseOrder model)
        {
            _context.PurchaseOrders.Add(model);
            _context.SaveChanges();
        }

        public void Update(PurchaseOrder model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(PurchaseOrder model)
        {
            _context.PurchaseOrders.Find(model);
            _context.PurchaseOrders.Remove(model);
            _context.SaveChanges();


        }

       

        public IEnumerable<PurchaseOrder> GetItems()
        {
            return _context.PurchaseOrders;
        }
    }
}
