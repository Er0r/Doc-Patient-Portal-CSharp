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
using System.Data.SqlClient;

namespace DPPMAIN
{
    public partial class DoctorRegister : Form
    {
        public static string docusername,docemail,docpassword,docdepartment,docclinic,docmobileno,doclocation;
        Thread th;
        DBAccess objdbaccess = new DBAccess();
        public DoctorRegister()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            docusername = txtdoctextname.Text;
            docemail = txtdocemail.Text;
            docpassword = txtdocpass.Text;
            docdepartment = cmbdept.Text;
            if (docdepartment == "0" || docdepartment == "")
            {
                MessageBox.Show("Please Select Doctor Department");
            }
            
            docclinic = txtdocclinic.Text;
            doclocation = cmblocation.Text;
            if (doclocation == "0" || doclocation == "")
            {
                MessageBox.Show("Please Select Clinic Location");
            }

            docmobileno = txtdocmobileno.Text;
            
            //MessageBox.Show(docdepartment);
            //MessageBox.Show(doclocation);
            if(docusername == "")
            {
                MessageBox.Show("Please Enter Doctor username");
            }
            else if(docemail == "")
            {
                MessageBox.Show("Please Enter Doctor Email");
            }
            else if(docpassword == "")
            {
                MessageBox.Show("Please Enter Doctor Password");
            }
            else if(docclinic == "")
            {
                MessageBox.Show("Please Enter Doctor Clinic Address");
            }
            else if(docmobileno == "")
            {
                MessageBox.Show("Please Enter Doctor Mobile No");
            }
            
            
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into DoctorRequestTable(DOCTORNAME,DOCTOREMAIL,DOCTORPASSWORD,DOCTORCLINIC,DOCTORDEPARTMENT,DOCTORLOCATION,DOCTORMOBILE) values(@docusername, @docemail, @docpassword, @docclinic,  @docdepartment,@doclocation,@docmobileno)");
                insertCommand.Parameters.AddWithValue("@docusername", docusername);
                insertCommand.Parameters.AddWithValue("@docemail", docemail);
                insertCommand.Parameters.AddWithValue("@docpassword", docpassword);
                insertCommand.Parameters.AddWithValue("@docclinic", docclinic);
                insertCommand.Parameters.AddWithValue("@docdepartment", docdepartment);
                insertCommand.Parameters.AddWithValue("@doclocation", doclocation);
                insertCommand.Parameters.AddWithValue("@docmobileno", docmobileno);
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backtodoctorfacade);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void backtodoctorfacade(object obj)
        {
            Application.Run(new Form1());
        }
        
    }
}
