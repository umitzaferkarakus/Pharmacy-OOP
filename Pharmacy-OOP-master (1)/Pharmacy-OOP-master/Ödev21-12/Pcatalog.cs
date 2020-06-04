 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class Pcatalog
    {
        public Store OurStore { get; set; }
        public Pdescripton UrunTanimi { get; set; }

        public Pcatalog()
        {
            this.OurStore = new Store();
        }
    }
}
