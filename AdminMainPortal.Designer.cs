namespace DPPMAIN
{
    partial class AdminMainPortal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnshowpatient = new System.Windows.Forms.Button();
            this.dtapprovepatient = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowDoctor = new System.Windows.Forms.Button();
            this.dtapproavedoctor = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtapprovepatient)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtapproavedoctor)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnshowpatient);
            this.tabPage1.Controls.Add(this.dtapprovepatient);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AdminRequest";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnshowpatient
            // 
            this.btnshowpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowpatient.Location = new System.Drawing.Point(636, 173);
            this.btnshowpatient.Name = "btnshowpatient";
            this.btnshowpatient.Size = new System.Drawing.Size(118, 111);
            this.btnshowpatient.TabIndex = 2;
            this.btnshowpatient.Text = "Show Request";
            this.btnshowpatient.UseVisualStyleBackColor = true;
            this.btnshowpatient.Click += new System.EventHandler(this.btnshowpatient_Click);
            // 
            // dtapprovepatient
            // 
            this.dtapprovepatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtapprovepatient.Location = new System.Drawing.Point(3, 84);
            this.dtapprovepatient.Name = "dtapprovepatient";
            this.dtapprovepatient.RowHeadersWidth = 51;
            this.dtapprovepatient.RowTemplate.Height = 24;
            this.dtapprovepatient.Size = new System.Drawing.Size(588, 332);
            this.dtapprovepatient.TabIndex = 1;
            this.dtapprovepatient.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtapprovepatient_RowHeaderMouseClick);
            this.dtapprovepatient.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtapprovepatient_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 87);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(166, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "You can Approve Patient Here";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowDoctor);
            this.tabPage2.Controls.Add(this.dtapproavedoctor);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DoctorRequest";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowDoctor
            // 
            this.btnShowDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDoctor.Location = new System.Drawing.Point(631, 186);
            this.btnShowDoctor.Name = "btnShowDoctor";
            this.btnShowDoctor.Size = new System.Drawing.Size(127, 111);
            this.btnShowDoctor.TabIndex = 2;
            this.btnShowDoctor.Text = "Show Request";
            this.btnShowDoctor.UseVisualStyleBackColor = true;
            this.btnShowDoctor.Click += new System.EventHandler(this.btnShowDoctor_Click);
            // 
            // dtapproavedoctor
            // 
            this.dtapproavedoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtapproavedoctor.Location = new System.Drawing.Point(0, 91);
            this.dtapproavedoctor.Name = "dtapproavedoctor";
            this.dtapproavedoctor.RowHeadersWidth = 51;
            this.dtapproavedoctor.RowTemplate.Height = 24;
            this.dtapproavedoctor.Size = new System.Drawing.Size(594, 332);
            this.dtapproavedoctor.TabIndex = 1;
            this.dtapproavedoctor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtapproavedoctor_RowHeaderMouseClick);
            this.dtapproavedoctor.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtapproavedoctor_RowHeaderMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 91);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(161, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "You can Approve Doctor Here";
            // 
            // AdminMainPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminMainPortal";
            this.Text = "AdminMainPortal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtapprovepatient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtapproavedoctor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnshowpatient;
        private System.Windows.Forms.DataGridView dtapprovepatient;
        private System.Windows.Forms.Button btnShowDoctor;
        private System.Windows.Forms.DataGridView dtapproavedoctor;
    }
}