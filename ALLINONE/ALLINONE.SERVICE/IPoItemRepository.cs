using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
   public interface IPoItemRepository
    {
        PoItem GetById(Int32 id);
        void Insert(PoItem model);
        void Update(PoItem model);
        void Delete(PoItem model);
        IEnumerable<PoItem> GetItems();
    }
}
