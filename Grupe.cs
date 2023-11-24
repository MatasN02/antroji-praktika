using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{  
    public class grupe
    {
        public int grupesID { get; set; }
        public string pavadinimas { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{grupesID}  {pavadinimas}";
            }
        }
    }
}
