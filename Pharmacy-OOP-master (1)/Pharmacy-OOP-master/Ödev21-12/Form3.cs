using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev21_12
{
    public partial class Form3 : Form
    {
        Form4 StoreProduct = new Form4();
        
        
        public static decimal TotalSaleAmount = 0;
        public static decimal CasualAmount = 0;

        
        public Form3()
        {
            InitializeComponent();
        }

        public static Pcatalog ProductCatalog = new Pcatalog();

        public static AccountBook AccountBook = new AccountBook();

        public static SalesList SatisKalemi = new SalesList();
        public static Sales Sales1 = new Sales();
        public static CashPayment Cash = new CashPayment();
        public static CreditCardPayment CreditCard = new CreditCardPayment();
        

        private void Form3_Load(object sender, EventArgs e)
        {

            foreach (product u in ProductCatalog.OurStore.ProductList)
            {
                lbProducts.Items.Add(u);
            }
            if (lbProducts.SelectedItem==null)
            {
                btnCalculate.Enabled = false;
            }
            else
            {
                btnCalculate.Enabled = true;
            }

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            product u = (product)lbProducts.SelectedItem;
            u.Description.Miktar = Convert.ToInt32(nudUnit.Value);
            lblTutar.Text = u.Description.Ctotal().ToString()+" TL";
            btnAddCart.Enabled = true;
        }

        private void BtnaddCart_Click(object sender, EventArgs e)
        {
           
            product u = (product)lbProducts.SelectedItem;
            u.Description.Miktar = Convert.ToInt32(nudUnit.Value);
           
            SatisKalemi.AddProduct(u);
            lbCart.Items.Add(u.Description.Pname + " " + u.Description.price + " x "+u.Description.Miktar+" = "+u.Description.Ctotal().ToString()+" TL");
            lblTutar.Text = "    ";
            lbProducts.SelectedItem = null;
            nudUnit.Value = 1;
            btnAddCart.Enabled = false;
            CasualAmount += u.Description.price * u.Description.Miktar;
            

        }

        private void BtnCalculateTotalAmount_Click(object sender, EventArgs e)
        {

            lblTotal.Text = CasualAmount.ToString()+"  TL";
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            Sales1.CreditPayment.AmountOfPayment= 0;
            Sales1.CashPayment.Pay(CasualAmount);
            lblDamount.Text = Sales1.CashPayment.AmountOfPayment.ToString()+" TL";
            btnOrderCheck.Visible = true;
            
        }

        private void RbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            Sales1.CashPayment.AmountOfPayment = 0;
            Sales1.CreditPayment.Pay(CasualAmount);
            lblDamount.Text = Sales1.CreditPayment.AmountOfPayment.ToString() + " TL";
            btnOrderCheck.Visible = true;
        }

        private void btnOrderCheck_Click(object sender, EventArgs e)
        {
            foreach (product u in SatisKalemi.ProductReceived)
            {
                ProductCatalog.OurStore.RemoveProduct(u);
            }
            SatisKalemi.ProductReceived.Clear();
            Sales1.Date = DateTime.Now;
            string messsage = "";
            string[] data1 = new string
            [lbCart.Items.Count];
            for (int i = 0; i < lbCart.Items.Count; i++)
            {
                data1[i] = lbCart.Items[i].ToString();
                messsage += data1[i] + "\n";
            }
            MessageBox.Show(""+AccountBook.OurStore.StoreName+
                            "\n"+AccountBook.OurStore.StoreAddress+
                            "\n\nSales Date : " + Sales1.Date.ToString() +
                            "\nTerminal Serial No : "+AccountBook.OurStore.Terminal1.SerialNo.ToString()+
                            "\n\nProduct Receivedr\n" + messsage +
                            "\n--------------------------------------------------------------"+
                            "\nTotal Amount : " + (Sales1.CreditPayment.AmountOfPayment+ Sales1.CashPayment.AmountOfPayment).ToString()+
                            "\n--------------------------------------------------------------"+
                            "\n\n Cashier : " + Form1.EntryCashier.Name + " " + Form1.EntryCashier.Surname
                );

            TotalSaleAmount += Sales1.CreditPayment.AmountOfPayment + Sales1.CashPayment.AmountOfPayment;
            Sales1.TotalAmount += TotalSaleAmount;
            btnCalculate.Enabled = false;
            btnAddCart.Enabled = false;
            btnCalculateTotalAmount.Enabled = false;
           
        }

        private void lbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItem == null)
            {
                btnCalculate.Enabled = false;
            }
            else
            {
                nudUnit.Value = 1;
                product u = (product)lbProducts.SelectedItem;
                nudUnit.Maximum = u.Description.Pstock;
                btnCalculate.Enabled = true;
            }
        }


        private void btnNewSlaeProgess_Click(object sender, EventArgs e)
        {
            CasualAmount = 0;
            if (Application.OpenForms[0] == this)
            {
                Application.Restart();
            }
            else
            {
                Form3 f = new Form3();
                f.Show();
                this.Close();

            }
            
        }

        private void btnStoreProgess_Click(object sender, EventArgs e)
        {
            StoreProduct.Show();
            this.Close();

        }

        private void labelCart_Click(object sender, EventArgs e)
        {

        }

        private void lbCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
