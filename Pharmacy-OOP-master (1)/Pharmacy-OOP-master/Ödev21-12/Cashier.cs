using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public  class Cashier : Person
    {
        public long IdNo { get; set; }
        public string InsuranceNo { get; set; }
        public Terminal Terminal { get; set; }

        public Cashier()
        {
            Terminal = new Terminal();
        }
        public override void PersonInformation(string Name, string Surname, string InsuranceNo)
        {
            base.PersonInformation(Name, Surname, InsuranceNo);
            this.InsuranceNo = InsuranceNo.ToUpper();
            
        }
      
        public Cashier(string Name, string Surname, string InsuranceNo, long Phone)
        {
            this.Name = Name.ToUpper();
            this.Surname = Surname.ToUpper();
            this.InsuranceNo = InsuranceNo.ToUpper();
            this.Phone = Phone;
        }
    }
}
