using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class Pdescripton
    {
        public string Pdefinition { get; set; }
        public string Pname { get; set; }
        public int Pcode { get; set; }
        public decimal price { get; set; }
        public int Pstock { get; set; }
        public decimal  total { get; set; }
        public int Miktar { get; set; }


        public List<product> Urunler { get; set; }
       
        public decimal Ctotal()
        {

            this.total = this.Miktar * this.price;
           
            return total;
        }

    }
}
