using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class product
    {
        public Pdescripton Description = new Pdescripton();

        public override string ToString()
        {
            return string.Format("{0}-{1} {2}", Description.Pname, Description.price , "TL");
        }
    }
}
