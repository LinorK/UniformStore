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
    /*
     * List of already existing usernames and passwords
     * The first four I played around with, the others are unused
     * (And the first 3 that I played around with might have inaccurate info because 
     * I played around with it, before I finished the application...)
     * USERNAME:            PASSWORD:
       ------------------------------
       ShoshiF	            SF123
       ShanaC	            SC123
       NechamaD	            ND123
       Linor	            LK123
       LeahS	            LS123
       AvigailJ	            AJ123
       EstyM	            EM123
       AvivaS	            AS123
       AvigailL	            AL123
       AlizaL	            AL456
       SimaS	            SS123
       SolikaS	            SS456
       SaralaS	            SS789
       EstiR	            ER123
     */

    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var users = db.customers.Select(c => c);
            int userId = 0;

            bool exists = false;

            foreach(var user in users)
            {
                if (tbxUsername.Text.Equals(user.UserName))
                {
                    exists = true;
                    userId = user.CustomerID;
                }
            }

            if (exists)
            {
                this.Hide();
                FrmHomePage fhp = new FrmHomePage(userId);
                fhp.ShowDialog();
            }

            else
                lblInvalidEntry.Text.Equals("Invalid Entry. Please Try Again");
        }

        private void btnCreateNewAct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNewAccount fna = new FrmNewAccount();
            fna.ShowDialog();
        }
    }
}
