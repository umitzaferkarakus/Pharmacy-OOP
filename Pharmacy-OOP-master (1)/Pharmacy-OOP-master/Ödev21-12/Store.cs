using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class Store
    {
        public List<product> ProductList { get; set; }
        public Terminal Terminal1 = new Terminal();
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }

        
        public void AddProduct(product u)
        {
            
           
            
            bool x = true;
           foreach (product ur in ProductList)
            {
               
                if (ur.Description.Pcode == u.Description.Pcode)
                {
                    x = false;
                    ur.Description.Pstock = ur.Description.Pstock + u.Description.Pstock;
                }
               
            }

           
            if(x==true)
            {
                ProductList.Add(u);
                x = true;

            }

            
        }
     
        public void RemoveProduct(product u )
        {   
             
            bool x = true;
            
            foreach (product ur in ProductList)
            {
                
               
                if (ur.Description.Pcode == u.Description.Pcode)
                {
                    x = false;
                    ur.Description.Pstock = ur.Description.Pstock - u.Description.Miktar;
                }

            }


            if (x == true)
            {
                ProductList.Remove(u);
                x = true;

            }
            
        }
         public  string productlist()
         {
             string message = "";
             foreach (product u in ProductList)
             {
                 {
                     message += "\n Product No: " + u.Description.Pcode.ToString() +
                              " Product Name: " + u.Description.Pname+
                              " Product Price: " + u.Description.price.ToString();
                 }

             }
             return message;
         }

        public Store()
        {
            this.StoreName = "Store Name";
            this.StoreAddress = "Store Address";
            this.Terminal1.SerialNo = 001;

            this.ProductList = new List<product>();
            product U1 = new product();
            product U2 = new product();
            product U3 = new product();
            product U4 = new product();
            product U5 = new product();
            product U6 = new product();
            product U7 = new product();
            product U8 = new product();
            product U9 = new product();
            product U10 = new product();
            product U11 = new product();
            product U12 = new product();
            product U13 = new product();
            product U14 = new product();
            product U15 = new product();


            U1.Description.Pcode = 001;
            U1.Description.Pdefinition = "Medicine";
            U1.Description.Pname = "Parol";
            U1.Description.price = 15;
            U1.Description.Pstock = 50;
            ProductList.Add(U1);

            U2.Description.Pcode = 002;
            U2.Description.Pdefinition = "Medicine";
            U2.Description.Pname = "Majezik";
            U2.Description.price = 17;
            U2.Description.Pstock = 45;
            ProductList.Add(U2);

            U3.Description.Pcode = 003;
            U3.Description.Pdefinition = "Care";
            U3.Description.Pname = "Slin Care Cream";
            U3.Description.price = 35;
            U3.Description.Pstock = 20;
            ProductList.Add(U3);

            U4.Description.Pcode = 004;
            U4.Description.Pdefinition = "Care";
            U4.Description.Pname = "Soap";
            U4.Description.price = 30;
            U4.Description.Pstock = 10;
            ProductList.Add(U4);

            U5.Description.Pcode = 005;
            U5.Description.Pdefinition = "Vitamin";
            U5.Description.Pname = "Supradyn";
            U5.Description.price = 20;
            U5.Description.Pstock = 20;
            ProductList.Add(U5);

            U6.Description.Pcode = 006;
            U6.Description.Pdefinition = "Vitamin";
            U6.Description.Pname = "Vitamin B";
            U6.Description.price = 50;
            U6.Description.Pstock = 10;
            ProductList.Add(U6);

            U7.Description.Pcode = 007;
            U7.Description.Pdefinition = "Medicine";
            U7.Description.Pname = "Dolorex";
            U7.Description.price = 20;
            U7.Description.Pstock = 30;
            ProductList.Add(U7);

            U8.Description.Pcode = 008;
            U8.Description.Pdefinition = "Medicine";
            U8.Description.Pname = "Nurofen";
            U8.Description.price = 19;
            U8.Description.Pstock = 37;
            ProductList.Add(U8);

            U9.Description.Pcode = 009;
            U9.Description.Pdefinition = "Medicine";
            U9.Description.Pname = "Arveles";
            U9.Description.price = 17;
            U9.Description.Pstock = 50;
            ProductList.Add(U9);

            U10.Description.Pcode = 010;
            U10.Description.Pdefinition = "Care";
            U10.Description.Pname = "Hair Cream";
            U10.Description.price = 45;
            U10.Description.Pstock = 6;
            ProductList.Add(U10);

            U11.Description.Pcode = 011;
            U11.Description.Pdefinition = "Care";
            U11.Description.Pname = "Hand Cream";
            U11.Description.price = 35;
            U11.Description.Pstock = 5;
            ProductList.Add(U11);

            U12.Description.Pcode = 0012;
            U12.Description.Pdefinition = "Care";
            U12.Description.Pname = "Shampoo";
            U12.Description.price = 27;
            U12.Description.Pstock = 20;
            ProductList.Add(U12);

            U13.Description.Pcode = 013;
            U13.Description.Pdefinition = "Medicine";
            U13.Description.Pname = "Klamoks";
            U13.Description.price = 26;
            U13.Description.Pstock = 50;
            ProductList.Add(U13);

            U14.Description.Pcode = 014;
            U14.Description.Pdefinition = "Medicine";
            U14.Description.Pname = "Aksef";
            U14.Description.price = 30;
            U14.Description.Pstock = 35;
            ProductList.Add(U14);

            U15.Description.Pcode = 015;
            U5.Description.Pdefinition = "Medicine";
            U15.Description.Pname = "Novo";
            U15.Description.price = 30;
            U15.Description.Pstock = 28;
            ProductList.Add(U15);
        }

    }
}
