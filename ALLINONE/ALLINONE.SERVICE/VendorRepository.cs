using System.Collections.Generic;
using System.Linq;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
    public class VendorRepository : IVendorRepository
    {

        ProjectContex _context = new ProjectContex();
        public Vendor GetById(int id)
        {
            var result = (from r in _context.Vendors
                          where r.VId == id
                          select r).FirstOrDefault();
            return result;
        }

        public void Insert(Vendor model)
        {
            _context.Vendors.Add(model);
            _context.SaveChanges();
        }

        public void Update(Vendor model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(Vendor model)
        {
            _context.Vendors.Find(model);
            _context.Vendors.Remove(model);
            _context.SaveChanges();


        }



        public IEnumerable<Vendor> GetItems()
        {
            return _context.Vendors;
        }
    }
}
