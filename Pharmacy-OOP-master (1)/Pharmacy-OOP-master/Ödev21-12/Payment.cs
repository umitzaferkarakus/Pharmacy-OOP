using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public abstract class Payment
    {
        public decimal AmountOfPayment { get; set; }

        public abstract void Pay(decimal tutar);
    }
}
