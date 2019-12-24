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
    public partial class AdminMainPortal : Form
    {
        
        DBAccess objdbaccess = new DBAccess();
        string connectionstring = @"Data Source=DESKTOP-RCR24TI;Initial Catalog=DPPMAIN;Integrated Security=True";
        
        public static String patname, patemail,patpassword,pataddress,patmobile, docname, docemail,docpassword,docdepartment,docclinic,doclocation;

        private void btnShowDoctor_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from DoctorRequestTable", sqlCon);
                DataTable dtDoctorUser = new DataTable();
                sqlDa.Fill(dtDoctorUser);
                dtapproavedoctor.DataSource = dtDoctorUser;
            }
        }

        private void btnshowpatient_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from PatientRequestTable", sqlCon);
                DataTable dtPatientUser = new DataTable();
                sqlDa.Fill(dtPatientUser);
                dtapprovepatient.DataSource = dtPatientUser;
            }
        }

        public AdminMainPortal()
        {
            InitializeComponent();
        }

        private void dtapprovepatient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            patname = dtapprovepatient.Rows[e.RowIndex].Cells[0].Value.ToString();
            patemail = dtapprovepatient.Rows[e.RowIndex].Cells[1].Value.ToString();
            patpassword = dtapprovepatient.Rows[e.RowIndex].Cells[2].Value.ToString();
            pataddress = dtapprovepatient.Rows[e.RowIndex].Cells[3].Value.ToString();
            patmobile = dtapprovepatient.Rows[e.RowIndex].Cells[4].Value.ToString();

            SqlCommand insertCommand = new SqlCommand("insert into PatientMainTable(PatientName,PatientEmail,PatientPassword,PatientAddress,PatientMobile) values(@patname, @patemail, @patpassword, @pataddress,  @patmobile)");
            insertCommand.Parameters.AddWithValue("@patname", patname);
            insertCommand.Parameters.AddWithValue("@patemail", patemail);
            insertCommand.Parameters.AddWithValue("@patpassword", patpassword);
            insertCommand.Parameters.AddWithValue("@pataddress", pataddress);
            insertCommand.Parameters.AddWithValue("@patmobile", patmobile);
            int row = objdbaccess.executeQuery(insertCommand);
            if (row == 1)
            {
                MessageBox.Show("Insertion request is Successfully Done.");
            }
            else
            {
                MessageBox.Show("Error!Please try again later.");
            }

            string q = "delete PatientRequestTable where PatientName = '" + patname + "'And PatientEmail = '" + patemail + "'";
            SqlCommand sqldelete = new SqlCommand(q);
            int row2 = objdbaccess.executeQuery(sqldelete);
            if (row2 == 1)
            {
                MessageBox.Show("Record Deleted Successfully.");
            }
            else
            {
                MessageBox.Show("Please Try Again Later. ");
            }

        }

        private void dtapprovepatient_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void dtapproavedoctor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            docname = dtapproavedoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
            docemail = dtapproavedoctor.Rows[e.RowIndex].Cells[2].Value.ToString();
            docpassword = dtapproavedoctor.Rows[e.RowIndex].Cells[3].Value.ToString();
            docclinic = dtapproavedoctor.Rows[e.RowIndex].Cells[4].Value.ToString();
            docdepartment = dtapproavedoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
            doclocation = dtapproavedoctor.Rows[e.RowIndex].Cells[6].Value.ToString();
            
            
            SqlCommand insertCommand = new SqlCommand("insert into DoctorMainTable(DoctorName,DoctorEmail,DoctorPassword,DoctorClinic,DoctorDepartment,DoctorLocation) values(@docname, @docemail, @docpassword, @docclinic,@docdepartment,@doclocation)");
            insertCommand.Parameters.AddWithValue("@docname", docname);
            insertCommand.Parameters.AddWithValue("@docemail", docemail);
            insertCommand.Parameters.AddWithValue("@docpassword", docpassword);
            insertCommand.Parameters.AddWithValue("@docclinic", docclinic);
            insertCommand.Parameters.AddWithValue("@docdepartment", docdepartment);
            insertCommand.Parameters.AddWithValue("@doclocation", doclocation);
            int row = objdbaccess.executeQuery(insertCommand);
            if (row == 1)
            {
                MessageBox.Show("Insertion request is Successfully Done.");
            }
            else
            {
                MessageBox.Show("Error!Please try again later.");
            }

            string q = "delete DoctorRequestTable where DOCTORNAME = '" + docname + "'And DOCTOREMAIL = '" + docemail + "'";
            SqlCommand sqldelete = new SqlCommand(q);
            int row2 = objdbaccess.executeQuery(sqldelete);
            if (row2 == 1)
            {
                MessageBox.Show("Record Deleted Successfully.");
            }
            else
            {
                MessageBox.Show("Please Try Again Later. ");
            }

        }

        private void dtapproavedoctor_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
