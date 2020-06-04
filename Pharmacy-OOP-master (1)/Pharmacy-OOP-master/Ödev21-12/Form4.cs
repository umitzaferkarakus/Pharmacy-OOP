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
    public partial class Form4 : Form
    {
       
        
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)

        {   
        
            foreach (product u in Form3.ProductCatalog.OurStore.ProductList)
            {
                lbProductCatalog.Items.Add(u);
            }
            lblProductStock.Text = Form3.AccountBook.PTotalNumber.ToString();
            lblTotalSalesAmount.Text = Form3.TotalSaleAmount.ToString();          
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            tabControlStoreProgress.SelectedTab = tabPageUrunEkle;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPname.Text =="" || txtPprice.Text=="" || txtPcode.Text=="" || cmbPdescription.Text=="" || nudPstock.Value==0)
            {
                MessageBox.Show("These fields cannot be left blank.");
            }
            else
            {
                product AddingProduct = new product();
                bool x = true;
                foreach (product u in Form3.ProductCatalog.OurStore.ProductList)
                {
                    if (u.Description.Pcode == Convert.ToInt32(txtPcode.Text))
                    {
                        lblAddedProduct.Text = "This code has the product.";
                        x = false;

                    }

                }

                if (x == true)
                {
                    AddingProduct.Description.Pname = txtPname.Text;
                    AddingProduct.Description.price = Convert.ToDecimal(txtPprice.Text);
                    AddingProduct.Description.Pstock = Convert.ToInt32(nudPstock.Value);
                    AddingProduct.Description.Pcode = Convert.ToInt32(txtPcode.Text);
                    AddingProduct.Description.Pdefinition = cmbPdescription.Text;
                    Form3.ProductCatalog.OurStore.AddProduct(AddingProduct);

                    lblAddedProduct.Text = AddingProduct.Description.Pcode.ToString() + " - " + AddingProduct.Description.Pname + " The product has been added. ";
                    lbProductCatalog.Items.Clear();
                    foreach (product u in Form3.ProductCatalog.OurStore.ProductList)
                    {
                        lbProductCatalog.Items.Add(u);
                    }
                    Form3.AccountBook.resetstock();
                    lblProductStock.Text = Form3.AccountBook.PTotalNumber.ToString();
                }


            }
           



            

        }

        private void btnShowAccountBook_Click(object sender, EventArgs e)
        {
            tabControlStoreProgress.SelectedTab = tabPageAccountBook;
          

            
        }

       

        private void btnSwAccountBook_Click(object sender, EventArgs e)
        {
            tabControlStoreProgress.SelectedTab = tabPageAccountBook;
            
          
        }

        private void LbProductCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbProductCatalog.SelectedItem = null;
        }

        private void btnShowSaleProgress_Click(object sender, EventArgs e)
        {
            Form3.CasualAmount = 0;

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

        private void txtPprice_TextChanged(object sender, EventArgs e)
        {
            if (txtPprice.Text ==0.ToString())
            {
                MessageBox.Show("The information entered is not valid.");
            }

        }

        private void txtPcode_TextChanged(object sender, EventArgs e)
        {
            if (txtPcode.Text == 0.ToString())
            {
                MessageBox.Show("The information entered is not valid.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ( txtStockProductID.Text == "" || nudStockProduct.Value == 0)
            {
                MessageBox.Show("These fields cannot be left blank.");
            }
            else
            {
                product UpdateProduct = new product();
                bool x = true;
                foreach (product u in Form3.ProductCatalog.OurStore.ProductList)
                {
                    if (u.Description.Pcode == Convert.ToInt32(txtStockProductID.Text))
                    {

                       UpdateProduct.Description.Pstock = Convert.ToInt32(nudStockProduct.Value);
                       UpdateProduct.Description.Pcode = Convert.ToInt32(txtStockProductID.Text);
                       Form3.ProductCatalog.OurStore.AddProduct(UpdateProduct);
                       lblGuncellenenUrun.Text = u.Description.Pcode.ToString() + " - " + u.Description.Pname + " The number of product is\n            " 
                           + (u.Description.Pstock - nudStockProduct.Value).ToString()
                           + "+" + nudStockProduct.Value.ToString() + "=" + u.Description.Pstock.ToString()
                           + "\n     updated in form. ";
                      
                       
                       Form3.AccountBook.resetstock();
                       lblProductStock.Text = Form3.AccountBook.PTotalNumber.ToString();
                       x = false;
                    }

                }

                if (x == true)
                {
                    MessageBox.Show("This product is not available in stock please add.");
                }


            }
        }

        private void btnAccountBook_Click(object sender, EventArgs e)
        {
            tabControlStoreProgress.SelectedTab = tabPageAccountBook;
        }

        private void btnAddCashier_Click(object sender, EventArgs e)
        {
            Form1.NewCashier.PersonInformation(txtAddingCashierName.Text, txtAddingCashierSurname.Text, txtInsuranceNo.Text);
            lblEklenenKasiyer.Text = "A new cashier has been added.";
        }

        private void lblPCode_Click(object sender, EventArgs e)
        {

        }

        private void labelUrunKatalogu_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblEklenenKasiyerAd_Click(object sender, EventArgs e)
        {

        }

        private void lblSigortaNo_Click(object sender, EventArgs e)
        {

        }

        private void txtEklenenKasiyerAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
