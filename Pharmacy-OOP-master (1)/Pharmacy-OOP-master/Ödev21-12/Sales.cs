using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class Sales
    {
        public DateTime Date { get; set; }
        public SalesList Satiskalemi = new SalesList();
        public decimal  TotalAmount { get; set; }

        public CashPayment CashPayment = new CashPayment();
        public CreditCardPayment CreditPayment = new CreditCardPayment();
    }
}
