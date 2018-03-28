namespace AndersonNotificationDesktopApiTest
{
    partial class EmailNotificationTestForm
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
            this.btnLoggedOut = new System.Windows.Forms.Button();
            this.chkEnableSsl = new System.Windows.Forms.CheckBox();
            this.chkIsBodyHtml = new System.Windows.Forms.CheckBox();
            this.txtEmailNotificationId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBcc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblIsBodyHtml = new System.Windows.Forms.Label();
            this.lblEnableSsl = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblBcc = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblEmailNotificationId = new System.Windows.Forms.Label();
            this.btnLoggedIn = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoggedOut
            // 
            this.btnLoggedOut.Location = new System.Drawing.Point(496, 356);
            this.btnLoggedOut.Name = "btnLoggedOut";
            this.btnLoggedOut.Size = new System.Drawing.Size(75, 23);
            this.btnLoggedOut.TabIndex = 0;
            this.btnLoggedOut.Text = "LoggedOut";
            this.btnLoggedOut.UseVisualStyleBackColor = true;
            this.btnLoggedOut.Click += new System.EventHandler(this.btnLoggedOut_Click);
            // 
            // chkEnableSsl
            // 
            this.chkEnableSsl.AutoSize = true;
            this.chkEnableSsl.Location = new System.Drawing.Point(12, 12);
            this.chkEnableSsl.Name = "chkEnableSsl";
            this.chkEnableSsl.Size = new System.Drawing.Size(73, 17);
            this.chkEnableSsl.TabIndex = 1;
            this.chkEnableSsl.Text = "EnableSsl";
            this.chkEnableSsl.UseVisualStyleBackColor = true;
            // 
            // chkIsBodyHtml
            // 
            this.chkIsBodyHtml.AutoSize = true;
            this.chkIsBodyHtml.Location = new System.Drawing.Point(12, 35);
            this.chkIsBodyHtml.Name = "chkIsBodyHtml";
            this.chkIsBodyHtml.Size = new System.Drawing.Size(79, 17);
            this.chkIsBodyHtml.TabIndex = 2;
            this.chkIsBodyHtml.Text = "IsBodyHtml";
            this.chkIsBodyHtml.UseVisualStyleBackColor = true;
            // 
            // txtEmailNotificationId
            // 
            this.txtEmailNotificationId.Location = new System.Drawing.Point(112, 58);
            this.txtEmailNotificationId.Name = "txtEmailNotificationId";
            this.txtEmailNotificationId.Size = new System.Drawing.Size(100, 20);
            this.txtEmailNotificationId.TabIndex = 3;
            this.txtEmailNotificationId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "EmailNotificationId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(112, 84);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bcc";
            // 
            // txtBcc
            // 
            this.txtBcc.Location = new System.Drawing.Point(112, 110);
            this.txtBcc.Name = "txtBcc";
            this.txtBcc.Size = new System.Drawing.Size(100, 20);
            this.txtBcc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Body";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(112, 136);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(100, 20);
            this.txtBody.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CC";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(112, 162);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(100, 20);
            this.txtCC.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(112, 188);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(112, 214);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 240);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(112, 266);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 20);
            this.txtSubject.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "To";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(112, 292);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(112, 318);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSuccess);
            this.groupBox1.Controls.Add(this.lblIsBodyHtml);
            this.groupBox1.Controls.Add(this.lblEnableSsl);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lblSubject);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.lblHost);
            this.groupBox1.Controls.Add(this.lblCC);
            this.groupBox1.Controls.Add(this.lblBody);
            this.groupBox1.Controls.Add(this.lblBcc);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.lblEmailNotificationId);
            this.groupBox1.Location = new System.Drawing.Point(218, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 379);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(11, 347);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 13);
            this.lblSuccess.TabIndex = 38;
            // 
            // lblIsBodyHtml
            // 
            this.lblIsBodyHtml.AutoSize = true;
            this.lblIsBodyHtml.Location = new System.Drawing.Point(11, 36);
            this.lblIsBodyHtml.Name = "lblIsBodyHtml";
            this.lblIsBodyHtml.Size = new System.Drawing.Size(0, 13);
            this.lblIsBodyHtml.TabIndex = 37;
            // 
            // lblEnableSsl
            // 
            this.lblEnableSsl.AutoSize = true;
            this.lblEnableSsl.Location = new System.Drawing.Point(11, 13);
            this.lblEnableSsl.Name = "lblEnableSsl";
            this.lblEnableSsl.Size = new System.Drawing.Size(0, 13);
            this.lblEnableSsl.TabIndex = 36;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(11, 321);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 13);
            this.lblUsername.TabIndex = 35;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(11, 295);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(0, 13);
            this.lblTo.TabIndex = 34;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(11, 269);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(0, 13);
            this.lblSubject.TabIndex = 33;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 243);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 13);
            this.lblPassword.TabIndex = 32;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(11, 217);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(0, 13);
            this.lblFrom.TabIndex = 31;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(11, 191);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(0, 13);
            this.lblHost.TabIndex = 30;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(11, 165);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(0, 13);
            this.lblCC.TabIndex = 29;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(11, 139);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(0, 13);
            this.lblBody.TabIndex = 28;
            // 
            // lblBcc
            // 
            this.lblBcc.AutoSize = true;
            this.lblBcc.Location = new System.Drawing.Point(11, 113);
            this.lblBcc.Name = "lblBcc";
            this.lblBcc.Size = new System.Drawing.Size(0, 13);
            this.lblBcc.TabIndex = 27;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(11, 87);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(0, 13);
            this.lblPort.TabIndex = 26;
            // 
            // lblEmailNotificationId
            // 
            this.lblEmailNotificationId.AutoSize = true;
            this.lblEmailNotificationId.Location = new System.Drawing.Point(11, 61);
            this.lblEmailNotificationId.Name = "lblEmailNotificationId";
            this.lblEmailNotificationId.Size = new System.Drawing.Size(0, 13);
            this.lblEmailNotificationId.TabIndex = 25;
            // 
            // btnLoggedIn
            // 
            this.btnLoggedIn.Location = new System.Drawing.Point(496, 327);
            this.btnLoggedIn.Name = "btnLoggedIn";
            this.btnLoggedIn.Size = new System.Drawing.Size(75, 23);
            this.btnLoggedIn.TabIndex = 26;
            this.btnLoggedIn.Text = "LoggedIn";
            this.btnLoggedIn.UseVisualStyleBackColor = true;
            this.btnLoggedIn.Click += new System.EventHandler(this.btnLoggedIn_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(496, 298);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 27;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // EmailNotificationTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnLoggedIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailNotificationId);
            this.Controls.Add(this.chkIsBodyHtml);
            this.Controls.Add(this.chkEnableSsl);
            this.Controls.Add(this.btnLoggedOut);
            this.Name = "EmailNotificationTestForm";
            this.Text = "EmailNotificationTestForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoggedOut;
        private System.Windows.Forms.CheckBox chkEnableSsl;
        private System.Windows.Forms.CheckBox chkIsBodyHtml;
        private System.Windows.Forms.TextBox txtEmailNotificationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblIsBodyHtml;
        private System.Windows.Forms.Label lblEnableSsl;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblBcc;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblEmailNotificationId;
        private System.Windows.Forms.Button btnLoggedIn;
        private System.Windows.Forms.Button btnSend;
    }
}