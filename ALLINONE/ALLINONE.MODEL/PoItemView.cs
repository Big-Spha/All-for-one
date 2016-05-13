using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLINONE.MODEL
{
   public  class PoItemView
    {
        public int PoItemId { get; set; }

        
        public string Name { get; set; }

       
        public double Unitprice { get; set; }
    }
}
