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
    public partial class LoginForm : Form
    {
        Thread th;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            
            this.Close();
            th = new Thread(openadminportal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opendoctorportal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openpatientportal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openadminportal(Object obj)
        {
            Application.Run(new AdminFacade());
        }

        private void opendoctorportal(Object obj)
        {
            Application.Run(new Form1());
        }

        private void openpatientportal(Object obj)
        {
            Application.Run(new PatientFacade());
        }
    }
}
