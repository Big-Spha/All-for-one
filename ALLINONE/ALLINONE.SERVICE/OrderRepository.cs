using System.Collections.Generic;
using System.Linq;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
  public class OrderRepository : IOrderRepository
    {
        ProjectContex _context = new ProjectContex();

        public Order GetById(int id)
        {
            var result = (from r in _context.Orders
                          where r.OrderId == id
                          select r).FirstOrDefault();
            return result;
        }

        public void Insert(Order model)
        {
            _context.Orders.Add(model);
            _context.SaveChanges();
        }

        public void Update(Order model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(Order model)
        {
            _context.Orders.Find(model);
            _context.Orders.Remove(model);
            _context.SaveChanges();


        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

       
    }
}
