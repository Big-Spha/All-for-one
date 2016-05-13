using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
 public  interface IPurchaseOrderRepository
    {
        PurchaseOrder GetById(Int32 id);
        void Insert(PurchaseOrder model);
        void Update(PurchaseOrder model);
        void Delete(PurchaseOrder model);
        IEnumerable<PurchaseOrder> GetItems();
    }
}
