using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ALLINONE.DATA
{
  public  class PurchaseOrder
    {
        [Key]
       public int  PoId { get; set; }

        public int  Porequisition { get; set; }
        public int VId  { get; set; }

        [Required]
        [Display(Name = "P. Order Terms")]
        public int  PoItemId { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime PoDate { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Qty { get; set; }

        [Required]
        [Display(Name = "P. Order Terms")]
        public string Terms { get; set; }


        public IEnumerable<Vendor> Vendors { get; set; }
        public IEnumerable<PoItem> PoItemses { get; set; }



    }
}
