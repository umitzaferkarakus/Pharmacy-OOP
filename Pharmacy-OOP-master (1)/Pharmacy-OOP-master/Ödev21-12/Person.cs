using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        protected long Phone { get; set; }

        public virtual void PersonInformation(string Name, string Surname, string InsuranceNo)
        {
            this.Name = Name.ToUpper();
            this.Surname = Surname.ToUpper();
        }
    }
}
