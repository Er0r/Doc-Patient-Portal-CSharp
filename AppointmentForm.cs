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
    public partial class AppointmentForm : Form
    {
        public static string patientname, patientproblem, suggestion;
        public static DateTime appointdate;
        public static string docname;
        string connectionstring = @"Data Source=DESKTOP-RCR24TI;Initial Catalog=DPPMAIN;Integrated Security=True";
        DBAccess objdbAccess = new DBAccess();
        Thread th;


        public AppointmentForm()
        {
            InitializeComponent();
        }

        

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                //sqlCon.Open();
                docname = Form1.username;
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from appointmentTable where AppointmentDateSet > '" + DateTime.Now + "' And DoctorName = '"+ docname + "'", sqlCon);
                DataTable dtuser = new DataTable();
                sqlDa.Fill(dtuser);
                dtappointmentview.DataSource = dtuser;
            }
        }

        

        private void dtappointmentview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            patientname = dtappointmentview.Rows[e.RowIndex].Cells[0].Value.ToString();
            patientproblem = dtappointmentview.Rows[e.RowIndex].Cells[4].Value.ToString();
            appointdate = Convert.ToDateTime(dtappointmentview.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backdocmainportal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            lblpatientname.Text = patientname;
            lblpatientproblem.Text = patientproblem;
            suggestion = txtdocsuggestion.Text;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(suggestion == "")
            {
                MessageBox.Show("Please Suggest something or Suggest a suitable time .");

            }
            else
            {
                string docname = Form1.username;
                string q = "Update appointmentTable SET Recommendation = '" + @suggestion + "' where PatientName = '" + @patientname + "' And (DoctorName = '" + @docname + "' And AppointmentDateSet = '"+ @appointdate + "')";
                SqlCommand sqlupdate = new SqlCommand(q);
                sqlupdate.Parameters.AddWithValue("@suggestion", @suggestion);
                int row = objdbAccess.executeQuery(sqlupdate);
                if (row == 1)
                {
                    MessageBox.Show("Information Updated.");
                }
                else
                {
                    MessageBox.Show("Please Try Again Later. ");
                }
            }
        }
        private void backdocmainportal(Object obj)
        {
            Application.Run(new DoctorMainPortal());
        }
    }
}
