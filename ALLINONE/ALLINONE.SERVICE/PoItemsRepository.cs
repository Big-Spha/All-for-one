using System.Collections.Generic;
using System.Linq;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
    public class PoItemsRepository : IPoItemRepository
    {

        ProjectContex _context = new ProjectContex();
        public PoItem GetById(int id)
        {
            var result = (from r in _context.PoItems
                          where r.PoItemId == id
                          select r).FirstOrDefault();
            return result;
        }

        public void Insert(PoItem model)
        {
            _context.PoItems.Add(model);
            _context.SaveChanges();
        }

        public void Update(PoItem model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(PoItem model)
        {
            _context.PoItems.Find(model);
            _context.PoItems.Remove(model);
            _context.SaveChanges();


        }



        public IEnumerable<PoItem> GetItems()
        {
            return _context.PoItems;
        }
    }
}
