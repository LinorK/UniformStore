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
    public partial class FrmHomePage : Form
    {
        private int userID;
        public FrmHomePage(int userID)
        {
            var db = new DataClasses1DataContext();
            var customers = db.customers.Select(c => c);

            this.userID = userID;
            InitializeComponent();
            lblHello.Text = "Hello, " + customers.Where(c => c.CustomerID.Equals(userID)).First().UserName + "!";
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProducts frp = new FrmProducts(userID);
            frp.ShowDialog();
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAccount fra = new FrmAccount(userID);
            fra.ShowDialog();
        }

        private void btnFindPurchases_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPurchases frp = new FrmPurchases(userID);
            frp.ShowDialog();
        }
        
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogIn fli = new FrmLogIn();
            fli.ShowDialog();
        }

    }
}
