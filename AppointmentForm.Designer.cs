namespace DPPMAIN
{
    partial class AppointmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnback = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtappointmentview = new System.Windows.Forms.DataGridView();
            this.SuggestionTab = new System.Windows.Forms.TabPage();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtdocsuggestion = new System.Windows.Forms.RichTextBox();
            this.lblpatientproblem = new System.Windows.Forms.Label();
            this.lblpatientname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtappointmentview)).BeginInit();
            this.SuggestionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 169);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(156, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO APPOINTMENT SECTION ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.SuggestionTab);
            this.tabControl1.Location = new System.Drawing.Point(-2, 177);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 440);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnback);
            this.tabPage1.Controls.Add(this.btnShow);
            this.tabPage1.Controls.Add(this.dtappointmentview);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PatientShow";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(821, 234);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(162, 66);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(821, 96);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(162, 66);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtappointmentview
            // 
            this.dtappointmentview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtappointmentview.Location = new System.Drawing.Point(0, 0);
            this.dtappointmentview.Name = "dtappointmentview";
            this.dtappointmentview.RowHeadersWidth = 51;
            this.dtappointmentview.RowTemplate.Height = 24;
            this.dtappointmentview.Size = new System.Drawing.Size(772, 411);
            this.dtappointmentview.TabIndex = 0;
            this.dtappointmentview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtappointmentview_RowHeaderMouseClick);
            // 
            // SuggestionTab
            // 
            this.SuggestionTab.Controls.Add(this.btnupdate);
            this.SuggestionTab.Controls.Add(this.txtdocsuggestion);
            this.SuggestionTab.Controls.Add(this.lblpatientproblem);
            this.SuggestionTab.Controls.Add(this.lblpatientname);
            this.SuggestionTab.Controls.Add(this.label4);
            this.SuggestionTab.Controls.Add(this.label3);
            this.SuggestionTab.Controls.Add(this.label2);
            this.SuggestionTab.Location = new System.Drawing.Point(4, 25);
            this.SuggestionTab.Name = "SuggestionTab";
            this.SuggestionTab.Padding = new System.Windows.Forms.Padding(3);
            this.SuggestionTab.Size = new System.Drawing.Size(1008, 411);
            this.SuggestionTab.TabIndex = 1;
            this.SuggestionTab.Text = "SuggestionTab";
            this.SuggestionTab.UseVisualStyleBackColor = true;
            this.SuggestionTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(826, 314);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(131, 70);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtdocsuggestion
            // 
            this.txtdocsuggestion.Location = new System.Drawing.Point(253, 208);
            this.txtdocsuggestion.Name = "txtdocsuggestion";
            this.txtdocsuggestion.Size = new System.Drawing.Size(537, 121);
            this.txtdocsuggestion.TabIndex = 5;
            this.txtdocsuggestion.Text = "";
            // 
            // lblpatientproblem
            // 
            this.lblpatientproblem.AutoSize = true;
            this.lblpatientproblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientproblem.Location = new System.Drawing.Point(295, 118);
            this.lblpatientproblem.Name = "lblpatientproblem";
            this.lblpatientproblem.Size = new System.Drawing.Size(34, 29);
            this.lblpatientproblem.TabIndex = 4;
            this.lblpatientproblem.Text = "...";
            // 
            // lblpatientname
            // 
            this.lblpatientname.AutoSize = true;
            this.lblpatientname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatientname.Location = new System.Drawing.Point(295, 43);
            this.lblpatientname.Name = "lblpatientname";
            this.lblpatientname.Size = new System.Drawing.Size(34, 29);
            this.lblpatientname.TabIndex = 3;
            this.lblpatientname.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Suggestion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Problem Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "PatientName:";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 617);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtappointmentview)).EndInit();
            this.SuggestionTab.ResumeLayout(false);
            this.SuggestionTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dtappointmentview;
        private System.Windows.Forms.TabPage SuggestionTab;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.RichTextBox txtdocsuggestion;
        private System.Windows.Forms.Label lblpatientproblem;
        private System.Windows.Forms.Label lblpatientname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}