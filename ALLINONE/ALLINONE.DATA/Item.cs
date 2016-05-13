using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ALLINONE.DATA
{
 public   class Item
    {
        public int ItemId { get; set; }

        [Required]
        [Display(Name = "Descreption")]
      
        public string Desc { get; set; }

        [Required]
        [Display(Name = "Size")]
        public string Size { get; set; }

        [Required]
        [Display(Name = "Instock")]
        public bool Instock { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }


    }
}
