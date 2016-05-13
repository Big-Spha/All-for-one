using System;

namespace ALLINONE.MODEL
{
   public  class PurchaseOrderView
    {
        public int PoId { get; set; }

        public int Porequisition { get; set; }
        public int VId { get; set; }

        
        public int PoItemId { get; set; }

        
        public DateTime PoDate { get; set; }

        public int Qty { get; set; }
        
        public string Terms { get; set; }

    }
}
