using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace DPPMAIN
{
    public partial class PatientRegister : Form
    {
        public static string patregname, patregemail, patregaddress, patregpassword, patregmobile;
        Thread th;
        

        DBAccess objdbaccess = new DBAccess();
        public PatientRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            patregname = txtpatusername.Text;
            patregemail = txtpatuseremail.Text;
            patregaddress = txtpataddress.Text;
            patregpassword = txtpatpassword.Text;
            patregmobile = txtpatmobile.Text;
            if (patregname == "")
            {
                MessageBox.Show("Please Enter the patient Name.");
            }
            else if (patregemail == "")
            {
                MessageBox.Show("Please Enter the Patient Email.");
            }
            else if (patregaddress == "")
            {
                MessageBox.Show("Please Enter the Patient Address.");
            }
            else if (patregpassword == "")
            {
                MessageBox.Show("Please Enter the Patient Password.");
            }
            else if (patregmobile == "")
            {
                MessageBox.Show("Please Enter the Patient Mobile.");
            }

            else
            {

                SqlCommand insertCommand = new SqlCommand("insert into PatientRequestTable(PatientName,PatientEmail,PatientPassword,Address,MobileNo) values(@patregname, @patregemail, @patregpassword, @patregaddress,  @patregmobile)");
                insertCommand.Parameters.AddWithValue("@patregname", patregname);
                insertCommand.Parameters.AddWithValue("@patregemail", patregemail);
                insertCommand.Parameters.AddWithValue("@patregpassword", patregpassword);
                insertCommand.Parameters.AddWithValue("@patregaddress", patregaddress);
                insertCommand.Parameters.AddWithValue("@patregmobile", patregmobile);

                int row = objdbaccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Registration request is Successfully Submitted.");
                }
                else
                {
                    MessageBox.Show("Error!Please try again later.");

                }
            }
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backtopatientfacade);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void backtopatientfacade(Object obj)
        {
            Application.Run(new PatientFacade());
        }
    }
}
