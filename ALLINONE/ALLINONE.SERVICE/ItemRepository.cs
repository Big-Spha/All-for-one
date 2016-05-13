using System.Collections.Generic;
using System.Linq;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
    public class ItemRepository : IItemRepository
    {
        ProjectContex _context = new ProjectContex();

        public Item GetById(int id)
        {
            var result = (from r in _context.Items
                where r.ItemId == id
                select r).FirstOrDefault();
            return result;
        }

        public void Insert(Item model)
        {
            _context.Items.Add(model);
            _context.SaveChanges();
        }

        public void Update(Item model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(Item model)
        {
            _context.Items.Find(model);
            _context.Items.Remove(model);
            _context.SaveChanges();


        }

        public IEnumerable<Item> GetItems()
        {
            return _context.Items;
        }
    }
}
