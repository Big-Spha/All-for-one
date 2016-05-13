using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ALLINONE.DATA
{
 public  class Student
    {
        [Key]
        public int StudentId { get; set; }


        [Required]
        [Display(Name = "Name")]
        public string  Name { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string  Email { get; set; }

        [Required]
        [Display(Name = "Room No")]
        public string  Address { get; set; }

        [Required]
        [Display(Name = "Course name")]
        public string Course { get; set; }
     public IEnumerable<Order> Orders { get; set; }

    }
}
