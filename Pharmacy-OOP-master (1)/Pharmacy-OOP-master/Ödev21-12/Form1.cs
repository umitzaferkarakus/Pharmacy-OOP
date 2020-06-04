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
    public partial class Form1 : Form
    {
        Form2 SelectionProcess = new Form2();
        Form4 StoreProcess=new Form4();
        public Form1()
        {
            InitializeComponent();
        }
        public static Cashier NewCashier = new Cashier();
        public static Cashier EntryCashier = new Cashier();
        public static Cashier Cashier1 = new Cashier("Eda Nur", "Özbek", "1" , 5546914761);
        public static Cashier Cashier2 = new Cashier("Mehmet Emin", "Köse","2",5077379364);
        public static Cashier Cashier3 = new Cashier("Arda", "Özsalman","3",5418513194);

        private void btnCashierEntry_Click(object sender, EventArgs e)
        {
            EntryCashier.Name = txtCashierName.Text.ToUpper();
            EntryCashier.Surname = txtCashierSurname.Text.ToUpper();
            EntryCashier.InsuranceNo = txtInsuranceNo.Text.ToUpper();


            if (EntryCashier.Name==Cashier1.Name && EntryCashier.Surname == Cashier1.Surname && EntryCashier.InsuranceNo == Cashier1.InsuranceNo)
            {
                EntryCashier.PersonInformation(txtCashierName.Text, txtCashierSurname.Text, txtInsuranceNo.Text);
                SelectionProcess.Show();
                this.Hide();
            }
            else if (EntryCashier.Name == Cashier2.Name && EntryCashier.Surname == Cashier2.Surname && EntryCashier.InsuranceNo == Cashier2.InsuranceNo)
            {
                EntryCashier.PersonInformation(txtCashierName.Text, txtCashierSurname.Text, txtInsuranceNo.Text);
                SelectionProcess.Show();
                this.Hide();
            }
            else if (EntryCashier.Name == Cashier3.Name && EntryCashier.Surname == Cashier3.Surname && EntryCashier.InsuranceNo == Cashier3.InsuranceNo)
            {
                EntryCashier.PersonInformation(txtCashierName.Text, txtCashierSurname.Text, txtInsuranceNo.Text);
                SelectionProcess.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Cashier Information Entered Is Incorrect. Please Try Again.");
                txtCashierName.Text = "";
                txtCashierSurname.Text = "";
                txtInsuranceNo.Text = "";
            }


        }

        private void txtCashierName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
