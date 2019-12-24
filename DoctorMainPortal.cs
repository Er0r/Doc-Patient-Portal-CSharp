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
    public partial class DoctorMainPortal : Form
    {
        Thread th;
        public DoctorMainPortal()
        {
            InitializeComponent();
        }

        private void btnShowPatient_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openappointmentform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backtodoctorfacade);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openappointmentform(Object obj)
        {
            Application.Run(new AppointmentForm());
        }
        private void backtodoctorfacade(Object obj)
        {
            Application.Run(new Form1());
        }

    }
}
