using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class SalesList
    {
        public List<product> ProductReceived { get; set; }

        public void AddProduct(product u)
        {
            ProductReceived.Add(u);

        }

        
        public string ProductList()
        {
            string message = "";
            foreach (product u in ProductReceived)
            {
                {
                    message += "\n\n Product No: " + u.Description.Pcode.ToString() +
                             "\nProduct Name: " + u.Description.Pname +
                             "\nProduct Price: " + u.Description.price.ToString() +" TL";
                }

            }
            return message;
        }


        public SalesList()
        {
            ProductReceived = new List<product>();
        }


    }
}
