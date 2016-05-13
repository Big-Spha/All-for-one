using System;
using System.ComponentModel.DataAnnotations;

namespace ALLINONE.MODEL
{
  public  class OrderView
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }
        public bool Closed { get; set; }
        public double TotalCharge { get; set; }

        public int StudentId { get; set; }
        public int OderItemId { get; set; }
    }
}
