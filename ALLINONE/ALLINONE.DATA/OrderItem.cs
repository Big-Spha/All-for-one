using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ALLINONE.DATA
{
  public   class OrderItem
    {
        [Key]
       public int OrderItemId { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Qty { get; set; }


        [Display(Name = "Order Id")]
        public int OrderId { get; set; }

        
        [Display(Name = "Item ID")]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public  Order Orders { get; set; }
     

        
       

    }
}
