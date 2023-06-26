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
    public partial class FrmNewAccount : Form
    {
        public FrmNewAccount()
        {
            InitializeComponent();
        }

        private void btnCreateNewAct_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            customer c = new customer();
            c.UserName = txbNewUser.Text;
            c.Password = txbNewPass.Text;
            c.AccountBalance = 0.00M;

            db.customers.InsertOnSubmit(c);
            db.SubmitChanges();

            this.Hide();
            FrmHomePage fhp = new FrmHomePage(c.CustomerID);
            fhp.ShowDialog();
        }
    }
}
