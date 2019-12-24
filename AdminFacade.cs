using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DPPMAIN
{
    public partial class AdminFacade : Form
    {
        public static string adminemail, adminpassword;
        DBAccess objdbaccess = new DBAccess();
        DataTable dtusers = new DataTable();
        Thread th;
        public AdminFacade()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            adminemail = txtadminuserEmail.Text;
            adminpassword = txtAdminPassword.Text;
            if(adminemail == "")
            {
                MessageBox.Show("Please Enter your Email");
            }
            else if(adminpassword == "")
            {
                MessageBox.Show("Please Enter your Password");
            }
            else
            {
                string query = "Select * from ADMINTABLE where ADMINEMAIL= '" + adminemail + "' AND ADMINPASSWORD = '" + adminpassword + "'";
                objdbaccess.readDatathroughAdapter(query, dtusers);
                if (dtusers.Rows.Count == 1)
                {
                    MessageBox.Show("You Logged In Successfully...");
                    this.Close();
                    th = new Thread(openadminmainportal);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                {
                    MessageBox.Show("Error ! Please Try Again Later. ");
                }
            }
        }
        private void openadminmainportal(Object obj)
        {
            Application.Run(new AdminMainPortal());
        }
    }
}
