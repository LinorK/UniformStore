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
    public partial class FrmProducts : Form
    {
        private int userID;
        public FrmProducts(int userID)
        {
            var db = new DataClasses1DataContext();
            var customers = db.customers.Select(c => c);

            this.userID = userID;
            InitializeComponent();
            lstProducts.SelectionMode = SelectionMode.None;

            String name = customers.Where(customer => customer.CustomerID.Equals(userID)).First().UserName;
            lblCartShow.Text = name + "'s Cart: $" 
                + customers.Where(customer => customer.CustomerID.Equals(userID)).First().AccountBalance;
            display();
            
        }

        public void display()
        {
            var db = new DataClasses1DataContext();
            var products = db.products.Select(p => p);
            foreach(var product in products)
            {
                lstProducts.Items.Add(product.ProductID + "     $" + product.Price + 
                    "     " + product.ProductName );
            }  
        }

        public void btnSelectItem_OnClick(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var products = db.products.Select(p => p);

            int id = Convert.ToInt32(txbItemID.Text);

            lblSelectedItem.Text = products.Where(p => p.ProductID.Equals(id)).First().ProductName;
        }

        public void btnAddToCart_OnClick(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var products = db.products.Select(p => p);
            var customers = db.customers.Select(c => c);

            var thisCustomer = customers.Where(c => c.CustomerID.Equals(userID)).First();
            decimal price = products.Where(p => p.ProductID.Equals(Convert.ToInt32(txbItemID.Text))).First().Price * Convert.ToDecimal(txbQuantity.Text);

            if (Decimal.Compare(thisCustomer.AccountBalance, 150.00M) > 0)
            {
                lblErrorMessage.Text = "ERROR! Account balance exceeds $150 - cannont make purchase.";
            }
            else
            {
                thisCustomer.AccountBalance = thisCustomer.AccountBalance + price;
                db.SubmitChanges();
                lblCartShow.Text = thisCustomer.UserName + "'s Cart: $" + thisCustomer.AccountBalance;

                Order order = new Order();
                order.CustomerID = userID;
                order.ProductID = Convert.ToInt32(txbItemID.Text);
                order.ProductAmount = Convert.ToInt32(txbQuantity.Text);
                order.OrderDate = DateTime.Now;
                order.TotalOrderAmount = price;

                db.Orders.InsertOnSubmit(order);
                db.SubmitChanges();
            }
        }

        public void TxbQuantity_TextChanged(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var products = db.products.Select(p => p);

            lblCurrTtl.Text = "Purchase Amount: $"
                + products.Where(p => p.ProductID.Equals(Convert.ToInt32(txbItemID.Text))).First().Price * Convert.ToDecimal(txbQuantity.Text);
        }

        private void btnPrdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHomePage fhp = new FrmHomePage(userID);
            fhp.ShowDialog();
        }
    }
}
