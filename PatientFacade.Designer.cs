namespace DPPMAIN
{
    partial class PatientFacade
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
            this.btnpatnewregister = new System.Windows.Forms.Button();
            this.btnpatsignin = new System.Windows.Forms.Button();
            this.txtpatientpassword = new System.Windows.Forms.TextBox();
            this.txtpatientusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpatnewregister
            // 
            this.btnpatnewregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpatnewregister.Location = new System.Drawing.Point(161, 416);
            this.btnpatnewregister.Name = "btnpatnewregister";
            this.btnpatnewregister.Size = new System.Drawing.Size(378, 59);
            this.btnpatnewregister.TabIndex = 13;
            this.btnpatnewregister.Text = "Create New Account";
            this.btnpatnewregister.UseVisualStyleBackColor = true;
            this.btnpatnewregister.Click += new System.EventHandler(this.btnpatnewregister_Click);
            // 
            // btnpatsignin
            // 
            this.btnpatsignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpatsignin.Location = new System.Drawing.Point(260, 332);
            this.btnpatsignin.Name = "btnpatsignin";
            this.btnpatsignin.Size = new System.Drawing.Size(168, 59);
            this.btnpatsignin.TabIndex = 12;
            this.btnpatsignin.Text = "Signin";
            this.btnpatsignin.UseVisualStyleBackColor = true;
            this.btnpatsignin.Click += new System.EventHandler(this.btnpatsignin_Click);
            // 
            // txtpatientpassword
            // 
            this.txtpatientpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatientpassword.Location = new System.Drawing.Point(282, 257);
            this.txtpatientpassword.Name = "txtpatientpassword";
            this.txtpatientpassword.Size = new System.Drawing.Size(252, 34);
            this.txtpatientpassword.TabIndex = 11;
            // 
            // txtpatientusername
            // 
            this.txtpatientusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatientusername.Location = new System.Drawing.Point(282, 172);
            this.txtpatientusername.Name = "txtpatientusername";
            this.txtpatientusername.Size = new System.Drawing.Size(252, 34);
            this.txtpatientusername.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(-42, -25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 128);
            this.panel1.TabIndex = 7;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(197, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(460, 32);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "WELCOME TO PATIENT FACADE";
            // 
            // PatientFacade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 510);
            this.Controls.Add(this.btnpatnewregister);
            this.Controls.Add(this.btnpatsignin);
            this.Controls.Add(this.txtpatientpassword);
            this.Controls.Add(this.txtpatientusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PatientFacade";
            this.Text = "PatientFacade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpatnewregister;
        private System.Windows.Forms.Button btnpatsignin;
        private System.Windows.Forms.TextBox txtpatientpassword;
        private System.Windows.Forms.TextBox txtpatientusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
    }
}