using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLINONE.DATA
{
    public class PoItem
    {
        [Key]
        public int PoItemId { get; set; }

        [Required]
        [Display(Name = " Item Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Unit Price")]
        public double Unitprice { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }

}
