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
    public partial class Form1 : Form
    {
        DBAccess dBAccess = new DBAccess();
        public static string username, userpassword;
        DataTable dtusers = new DataTable();
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            username = txtdoctorusername.Text;
            userpassword = txtdocpassword.Text;

            if (username == "")
            {
                MessageBox.Show("Please Enter your Name.");
            }
            else if (userpassword == "")
            {
                MessageBox.Show("Please Enter your Password");
            }
            else
            {
                string query = "Select * from DoctorMainTable where DoctorName= '" + username + "' AND DoctorPassword = '" + userpassword + "'";
                dBAccess.readDatathroughAdapter(query, dtusers);
                if (dtusers.Rows.Count == 1)
                {
                    MessageBox.Show("You Logged In Successfully...");
                    this.Close();
                    th = new Thread(opendoctormainportal);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                {
                    MessageBox.Show("Error ! Please Try Again Later. ");
                }
            }
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opendocregister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void opendoctormainportal(object obj)
        {
            Application.Run(new DoctorMainPortal());
        }
        private void opendocregister(object obj)
        {
            Application.Run(new DoctorRegister());
        }
    }


}
