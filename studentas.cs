using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class studentas
    {
        public int studentoId { get; set; }
        public string vardas { get; set; }
        public string pavarde { get; set; }
        public string pavadinimas { get; set; }


        public string FullInfo
        {
            get
            {
                return $"{ studentoId } { vardas }  { pavarde } {pavadinimas}";
            }
        }
    }
}
