using System.ComponentModel.DataAnnotations;

namespace ALLINONE.MODEL
{
   public class StudentView
    { 

    [Key]
    public int StudentId { get; set; }

    public string Name { get; set; }

    public string Lastname { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string Course { get; set; }
}
}

