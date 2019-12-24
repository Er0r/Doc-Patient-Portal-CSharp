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
    public partial class PatientFacade : Form
    {
        Thread th;
        DBAccess dBAccess = new DBAccess();
        public static string patuserename, patuserpassword;
        DataTable dtusers = new DataTable();
        public PatientFacade()
        {
            InitializeComponent();
        }

        private void btnpatsignin_Click(object sender, EventArgs e)
        {
            patuserename = txtpatientusername.Text;
            patuserpassword = txtpatientpassword.Text;

            if (patuserename == "")
            {
                MessageBox.Show("Please Enter your Name.");
            }
            if (patuserpassword == "")
            {
                MessageBox.Show("Please Enter your Password");
            }
            else
            {
                string query = "Select * from PatientMainTable where PatientName= '" + patuserename + "' AND PatientPassword = '" + patuserpassword + "'";
                dBAccess.readDatathroughAdapter(query, dtusers);
                if (dtusers.Rows.Count == 1)
                {
                    MessageBox.Show("You Logged In Successfully...");
                    this.Close();
                    th = new Thread(openpatientmainportal);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                {
                    MessageBox.Show("Error ! Please Try Again Later. ");
                }
            }
        }

        private void btnpatnewregister_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openpatregister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openpatregister(Object obj)
        {
            Application.Run(new PatientRegister());
        }
        private void openpatientmainportal(Object obj)
        {
            Application.Run(new PatientMainPortal());
        }

    }
}
