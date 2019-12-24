using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPPMAIN
{
    public partial class PatientMainPortal : Form
    {
        public static string docname,patientname,docclinic,doclocation,docdepartment;
        public static DateTime appointmentdate, today;
        string connectionstring = @"Data Source=DESKTOP-RCR24TI;Initial Catalog=DPPMAIN;Integrated Security=True";
        DBAccess objdbaccess = new DBAccess();
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-RCR24TI;Initial Catalog=DPPMAIN;Integrated Security=True");
        
        

        public PatientMainPortal()
        {
            InitializeComponent();
        }

        

        private void cmblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            doclocation = cmblocation.Text;

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            docdepartment = cmbdocdept.Text;
        }

        

        private void btnShow_Click(object sender, EventArgs e)
        {
            patientname = PatientFacade.patuserename;
            doclocation = cmblocation.Text;
            if(doclocation == "Choose Location:" || doclocation == "" )
            {
                MessageBox.Show("Please choose Location.");
            }
            else if(docdepartment == "Choose Department:" || docdepartment == "")
            {
                MessageBox.Show("Please choose Department.");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("Select DoctorName,DoctorClinic, DoctorLocation from DoctorMainTable where DoctorLocation = '" + doclocation + "' And DoctorDepartment = '"+ docdepartment + "'", sqlCon);
                    DataTable dtuser = new DataTable();
                    sqlDa.Fill(dtuser);
                    dtgriddocshow.DataSource = dtuser;
                }
            }
        }
        private void dtgriddocshow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            docname = dtgriddocshow.Rows[e.RowIndex].Cells[0].Value.ToString();
            docclinic = dtgriddocshow.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            lbldocname.Text = docname;
            lblclinicloc.Text = doclocation;
        }
        private void btnsetappointment_Click(object sender, EventArgs e)
        {
            
            appointmentdate = dtappointmentdate.Value.Date;
            today = DateTime.Now.Date;
            String prob = txtproblemdefination.Text;
            String rec = "";
            if (appointmentdate < today)
            {
                MessageBox.Show("Please Enter Correct Date.");
            }
            else
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT count(*) FROM appointmentTable WHERE PatientName = @patname And (DoctorName = @docname And AppointmentDateSet = @appointmentdate )", sqlCon);
                check_User_Name.Parameters.AddWithValue("@patname", patientname);
                check_User_Name.Parameters.AddWithValue("@docname", docname);
                check_User_Name.Parameters.AddWithValue("@appointmentdate", appointmentdate);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }
                int UserExist = (Int32)check_User_Name.ExecuteScalar();
                sqlCon.Close();
                if (UserExist > 0)
                {

                    MessageBox.Show("You can't make appointment twice a day. ");
                }

                else
                {
                    SqlCommand insertCommand = new SqlCommand("insert into appointmentTable(PatientName,DoctorName,ClinicLocation,AppointmentDateSet,Problem,Recommendation) values(@patname, @docname, @doclocation, @appointmentdate,@prob,@rec)");
                    insertCommand.Parameters.AddWithValue("@patname", patientname);
                    insertCommand.Parameters.AddWithValue("@docname", docname);
                    insertCommand.Parameters.AddWithValue("@doclocation", doclocation);
                    insertCommand.Parameters.AddWithValue("@appointmentdate", appointmentdate);
                    insertCommand.Parameters.AddWithValue("@prob", prob);
                    insertCommand.Parameters.AddWithValue("@rec", rec);
                    int row = objdbaccess.executeQuery(insertCommand);
                    if (row == 1)
                    {
                        MessageBox.Show("Appointment is Successfully Done.");
                    }
                    else
                    {
                        MessageBox.Show("Error!Please try again later.");
                    }
                    sqlCon.Close();
                }

            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            //sqlCon.Open();
            docname = Form1.username;
            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from appointmentTable where AppointmentDateSet > '" + DateTime.Now + "' And PatientName = '" + patientname + "'", sqlCon);
            DataTable dtuser = new DataTable();
            sqlDa.Fill(dtuser);
            dtgridpatientview.DataSource = dtuser;
        }

        private void dtgridpatientview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string patient = dtgridpatientview.Rows[e.RowIndex].Cells[0].Value.ToString();
            string doctor = dtgridpatientview.Rows[e.RowIndex].Cells[1].Value.ToString();
            string prob = dtgridpatientview.Rows[e.RowIndex].Cells[4].Value.ToString();
            string rec = dtgridpatientview.Rows[e.RowIndex].Cells[5].Value.ToString();
            MessageBox.Show("Patient Name: "+ patient + "\n"
                + "Doctor Name: " + doctor + "\n"+
                "Patient Problem: "+ prob+ "\n"
                +"Recommendation: "+rec);
        }
    }
}
