using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class CreditCardPayment : Payment
    {
        private const decimal DiscountRate = 0.03M;
        public decimal Discount { get; private set; }
        public override void Pay(decimal tutar)
        {
            Discount = tutar * DiscountRate;
            AmountOfPayment = tutar - Discount;


        }
    }
}
