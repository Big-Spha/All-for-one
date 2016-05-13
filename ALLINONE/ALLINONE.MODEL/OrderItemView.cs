using System.ComponentModel.DataAnnotations;

namespace ALLINONE.MODEL
{
    public class OrderItemView
    {
        [Key]
        public int OderItemId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Qty { get; set; }
    }
}
