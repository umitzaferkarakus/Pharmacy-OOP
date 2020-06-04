using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class AccountBook
    {
        public Sales Sales1 = new Sales();
        public Store OurStore = new Store();
        private int Ptotalnumber;

        public int PTotalNumber
        {
            get
            {
                Cnumberproduct();
                return Ptotalnumber; 
            }
            
            
        }
        public void resetstock()
        {
            Ptotalnumber = 0;

        }
        
        public void Cnumberproduct()
        {
            Ptotalnumber = 0;
            foreach (product u in Form3.ProductCatalog.OurStore.ProductList)
            {
                Ptotalnumber += u.Description.Pstock;
            }
            
            
        }

        private decimal totalsalesamount;

        public decimal TotalSalesAmount
        {
            get { return totalsalesamount; }
        }

        public void CTotalSalesAmount()
        {
            totalsalesamount = Sales1.CreditPayment.AmountOfPayment + Sales1.CashPayment.AmountOfPayment;
        }
        
    }
}
