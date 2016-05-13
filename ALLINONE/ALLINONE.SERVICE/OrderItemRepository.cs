using System.Collections.Generic;
using System.Linq;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
    public class OrderItemRepository : IOrderItemsRepository
    {
        ProjectContex _context = new ProjectContex();

        public OrderItem GetById(int id)
        {
            var result = (from r in _context.OrderItems
                where r.OrderItemId == id
                select r).FirstOrDefault();
            return result;
        }

        public void Insert(OrderItem model)
        {
            _context.OrderItems.Add(model);
            _context.SaveChanges();
        }

        public void Update(OrderItem model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(OrderItem model)
        {
            _context.OrderItems.Find(model);
            _context.OrderItems.Remove(model);
            _context.SaveChanges();


        }

        public IEnumerable<OrderItem> GetOrderItems()
        {
            return _context.OrderItems;
        }

       
    }
}
