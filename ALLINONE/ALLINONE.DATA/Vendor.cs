using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLINONE.DATA
{
    public class Vendor
    {
        [Key]
        public int VId { get; set; }

        [Required]
        [Display(Name = "Company name")]
        public string CName { get; set; }


        [Required]
        [Display(Name = "Addres")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Contact Parson")]
        public string Pname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
