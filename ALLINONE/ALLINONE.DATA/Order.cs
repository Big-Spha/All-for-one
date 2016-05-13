using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ALLINONE.DATA
{
   public class Order
    {
        [Key]

        public int OrderId{ get; set; }
    
        [Required]
        [Display(Name="Order Data")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "Status")]
        public bool Closed { get; set; }


        [Required]
        [Display(Name = "Total Price")]
        public double TotalCharge { get; set; }

        [Display(Name = "Student No")]
        public int StudentId { get; set; }

        [Display(Name = "Order Item Id")]
        public int OderItemId { get; set; }

        public Student Students { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
      
}
}
