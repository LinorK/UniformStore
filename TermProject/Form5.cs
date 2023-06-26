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
    public partial class FrmPurchases : Form
    {
        private int userID;
        public FrmPurchases(int userID)
        {
            this.userID = userID;
            InitializeComponent();
        }

        private void btnPurBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHomePage fhp = new FrmHomePage(userID);
            fhp.ShowDialog();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var myOrders = db.Orders.Where(p => p.CustomerID.Equals(userID));
            var products = db.products.Select(p => p);

            lbxPurchases.Items.Clear();
            displayList(myOrders, products);
        }

        private void btnViewDate_Click(object sender, EventArgs e)
        {
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            dateStart.Visible = true;
            dateEnd.Visible = true;
            btnViewPur2.Visible = true;
        }

        private void btnViewPur2_Click(object sender, EventArgs e)
        {
            lbxPurchases.Items.Clear();

            var db = new DataClasses1DataContext();
            var products = db.products.Select(p => p);
            var myOrders = db.Orders.Where(p => p.OrderDate >= DateTime.Parse(dateStart.Text)
                        && p.OrderDate <= DateTime.Parse(dateEnd.Text)
                        && p.CustomerID.Equals(userID));

            displayList(myOrders, products);
       
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            dateStart.Visible = false;
            dateEnd.Visible = false;
            btnViewPur2.Visible = false;
        }

        private void displayList(IEnumerable<Order> orders, IEnumerable<product> products)
        {
            foreach (var order in orders)
            {
                lbxPurchases.Items.Add("Order ID: " + order.OrderID + ",  Product ID: " + order.ProductID
                    + ",  Product Name: " + products.Where(p => p.ProductID.Equals(order.ProductID)).First().ProductName
                    + ",  Amount Purchased: " + order.ProductAmount
                    + ",  Total Price:  $" + order.TotalOrderAmount + ",  Order Date: " + order.OrderDate.ToString());
            }
        }

        private void btnViewPrice_Click(object sender, EventArgs e)
        {
            lblDollarSign1.Visible = true;
            lblDollarSign2.Visible = true;
            txbLowRange.Visible = true;
            txbUpRange.Visible = true;
            lblLowRange.Visible = true;
            lblUpRange.Visible = true;
            btnGo2.Visible = true;
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            decimal lowRange = Convert.ToDecimal(txbLowRange.Text);
            decimal upperRange = Convert.ToDecimal(txbUpRange.Text);

            var db = new DataClasses1DataContext();
            var myOrders = db.Orders.Where(o => o.TotalOrderAmount >= lowRange 
                && o.TotalOrderAmount <= upperRange && o.CustomerID.Equals(userID));
            var products = db.products.Select(p => p);

            lbxPurchases.Items.Clear();
            displayList(myOrders, products);

            lblDollarSign1.Visible = false;
            lblDollarSign2.Visible = false;
            txbLowRange.Visible = false;
            txbUpRange.Visible = false;
            lblLowRange.Visible = false;
            lblUpRange.Visible = false;
            btnGo2.Visible = false;
        }
    }
}
