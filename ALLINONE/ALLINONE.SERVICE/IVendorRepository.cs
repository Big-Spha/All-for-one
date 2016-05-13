using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
  public interface IVendorRepository
    {
        Vendor GetById(Int32 id);
        void Insert(Vendor model);
        void Update(Vendor model);
        void Delete(Vendor model);
        IEnumerable<Vendor> GetItems();
    }
}
