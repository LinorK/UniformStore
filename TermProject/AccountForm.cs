using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{   
    public partial class FrmAccount : Form
    {
        private int userID;
        public FrmAccount(int userID)
        {
            this.userID = userID;
            InitializeComponent();

            var db = new DataClasses1DataContext();
            var customers = db.customers.Select(c => c);

            lblActTitle.Text = customers.Where(c => c.CustomerID.Equals(userID)).First().UserName + "'s Account";
            lblCartTtlShow.Text = "Your Cart Total: " 
                + Convert.ToString(customers.Where(c => c.CustomerID.Equals(userID)).First().AccountBalance);
        }

        private void btnActBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHomePage fhp = new FrmHomePage(userID);
            fhp.ShowDialog();
        }

        private void btnApplyPay_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var customers = db.customers.Select(c => c);

            var thisCustomer = customers.Where(c => c.CustomerID.Equals(userID)).First();

            decimal payment = Convert.ToDecimal(txbPayment.Text);
            thisCustomer.AccountBalance -= payment;
            db.SubmitChanges();

            lblCartTtlShow.Text = "Your Cart Total: "
                + Convert.ToString(customers.Where(c => c.CustomerID.Equals(userID)).First().AccountBalance);
        }
    }
}
