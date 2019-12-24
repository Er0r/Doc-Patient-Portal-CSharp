namespace DPPMAIN
{
    partial class PatientMainPortal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbdocdept = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmblocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgriddocshow = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblclinicloc = new System.Windows.Forms.Label();
            this.lbldocname = new System.Windows.Forms.Label();
            this.btnsetappointment = new System.Windows.Forms.Button();
            this.txtproblemdefination = new System.Windows.Forms.RichTextBox();
            this.dtappointmentdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnshowall = new System.Windows.Forms.Button();
            this.dtgridpatientview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgriddocshow)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridpatientview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(199, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO PATIENT MAIN PORTAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 155);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 512);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage1.Controls.Add(this.cmbdocdept);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnShow);
            this.tabPage1.Controls.Add(this.cmblocation);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtgriddocshow);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DoctorsTab";
            // 
            // cmbdocdept
            // 
            this.cmbdocdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdocdept.FormattingEnabled = true;
            this.cmbdocdept.Items.AddRange(new object[] {
            "Choose Department:",
            "Surgery",
            "Medicine"});
            this.cmbdocdept.Location = new System.Drawing.Point(425, 20);
            this.cmbdocdept.Name = "cmbdocdept";
            this.cmbdocdept.Size = new System.Drawing.Size(129, 37);
            this.cmbdocdept.TabIndex = 5;
            this.cmbdocdept.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(331, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dept:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(45, 20);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(154, 45);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cmblocation
            // 
            this.cmblocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmblocation.FormattingEnabled = true;
            this.cmblocation.Items.AddRange(new object[] {
            "Choose Location:",
            "Bashundhara",
            "Mirpur",
            "Mohakhali",
            "Savar"});
            this.cmblocation.Location = new System.Drawing.Point(676, 20);
            this.cmblocation.Name = "cmblocation";
            this.cmblocation.Size = new System.Drawing.Size(198, 37);
            this.cmblocation.TabIndex = 2;
            this.cmblocation.SelectedIndexChanged += new System.EventHandler(this.cmblocation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(560, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // dtgriddocshow
            // 
            this.dtgriddocshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgriddocshow.Location = new System.Drawing.Point(-1, 80);
            this.dtgriddocshow.Name = "dtgriddocshow";
            this.dtgriddocshow.RowHeadersWidth = 51;
            this.dtgriddocshow.RowTemplate.Height = 24;
            this.dtgriddocshow.Size = new System.Drawing.Size(976, 403);
            this.dtgriddocshow.TabIndex = 0;
            this.dtgriddocshow.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgriddocshow_RowHeaderMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.Controls.Add(this.lblclinicloc);
            this.tabPage2.Controls.Add(this.lbldocname);
            this.tabPage2.Controls.Add(this.btnsetappointment);
            this.tabPage2.Controls.Add(this.txtproblemdefination);
            this.tabPage2.Controls.Add(this.dtappointmentdate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AppointmentTab";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblclinicloc
            // 
            this.lblclinicloc.AutoSize = true;
            this.lblclinicloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclinicloc.Location = new System.Drawing.Point(303, 97);
            this.lblclinicloc.Name = "lblclinicloc";
            this.lblclinicloc.Size = new System.Drawing.Size(34, 29);
            this.lblclinicloc.TabIndex = 9;
            this.lblclinicloc.Text = "...";
            // 
            // lbldocname
            // 
            this.lbldocname.AutoSize = true;
            this.lbldocname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldocname.Location = new System.Drawing.Point(303, 39);
            this.lbldocname.Name = "lbldocname";
            this.lbldocname.Size = new System.Drawing.Size(34, 29);
            this.lbldocname.TabIndex = 8;
            this.lbldocname.Text = "...";
            // 
            // btnsetappointment
            // 
            this.btnsetappointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetappointment.Location = new System.Drawing.Point(262, 384);
            this.btnsetappointment.Name = "btnsetappointment";
            this.btnsetappointment.Size = new System.Drawing.Size(289, 60);
            this.btnsetappointment.TabIndex = 7;
            this.btnsetappointment.Text = "Set Appointment";
            this.btnsetappointment.UseVisualStyleBackColor = true;
            this.btnsetappointment.Click += new System.EventHandler(this.btnsetappointment_Click);
            // 
            // txtproblemdefination
            // 
            this.txtproblemdefination.Location = new System.Drawing.Point(330, 235);
            this.txtproblemdefination.Name = "txtproblemdefination";
            this.txtproblemdefination.Size = new System.Drawing.Size(470, 101);
            this.txtproblemdefination.TabIndex = 6;
            this.txtproblemdefination.Text = "";
            // 
            // dtappointmentdate
            // 
            this.dtappointmentdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtappointmentdate.Location = new System.Drawing.Point(342, 168);
            this.dtappointmentdate.Name = "dtappointmentdate";
            this.dtappointmentdate.Size = new System.Drawing.Size(418, 34);
            this.dtappointmentdate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Problem Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "SetAppointmentDate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "DoctorName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clinic Location:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnshowall);
            this.tabPage3.Controls.Add(this.dtgridpatientview);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(978, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ReportTab";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnshowall
            // 
            this.btnshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowall.Location = new System.Drawing.Point(326, 29);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(183, 53);
            this.btnshowall.TabIndex = 1;
            this.btnshowall.Text = "Show";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // dtgridpatientview
            // 
            this.dtgridpatientview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridpatientview.Location = new System.Drawing.Point(3, 106);
            this.dtgridpatientview.Name = "dtgridpatientview";
            this.dtgridpatientview.RowHeadersWidth = 51;
            this.dtgridpatientview.RowTemplate.Height = 24;
            this.dtgridpatientview.Size = new System.Drawing.Size(972, 368);
            this.dtgridpatientview.TabIndex = 0;
            this.dtgridpatientview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgridpatientview_RowHeaderMouseClick);
            // 
            // PatientMainPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 627);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "PatientMainPortal";
            this.Text = "PatientMainPortal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgriddocshow)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridpatientview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgriddocshow;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmblocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdocdept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsetappointment;
        private System.Windows.Forms.RichTextBox txtproblemdefination;
        private System.Windows.Forms.DateTimePicker dtappointmentdate;
        private System.Windows.Forms.Label lblclinicloc;
        private System.Windows.Forms.Label lbldocname;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.DataGridView dtgridpatientview;
    }
}