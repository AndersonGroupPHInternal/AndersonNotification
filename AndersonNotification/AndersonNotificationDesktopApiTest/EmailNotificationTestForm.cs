using AndersonNotificationConsumer;
using AndersonNotificationModel;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace AndersonNotificationDesktopApiTest
{
    public partial class EmailNotificationTestForm : Form
    {
        private EmailNotification _emailNotification;
        private IEmailNotificationApi _iEmailNotificationApi;
        private ITestApi  _iTestApi;
        public EmailNotificationTestForm()
        {
            InitializeComponent();
            _iEmailNotificationApi = new EmailNotificationApi();
            _iTestApi = new TestApi();
        }

        private async void btnLoggedIn_Click(object sender, EventArgs e)
        {
            EmailNotification();
            _emailNotification = await _iTestApi.LoggedIn(_emailNotification);
            SetResults();
        }

        private async void btnLoggedOut_Click(object sender, EventArgs e)
        {
            EmailNotification();
            _emailNotification = await _iTestApi.LoggedOut(_emailNotification);
            SetResults();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                EmailNotification();
                SendEmail();
                _emailNotification = await _iEmailNotificationApi.Create(_emailNotification);
                //SetResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Testing Notification", MessageBoxButtons.OK);
            }
        }

        private void EmailNotification()
        {
            _emailNotification = new EmailNotification
            {
                EnableSsl = chkEnableSsl.Checked,
                IsBodyHtml = chkIsBodyHtml.Checked,

                EmailNotificationId = Convert.ToInt32(txtEmailNotificationId.Text.ToString()),
                Port = Convert.ToInt32(txtPort.Text.ToString()),

                Bcc = txtBcc.Text.ToString(),
                Body = txtBody.Text.ToString(),
                CC = txtCC.Text.ToString(),
                Host = txtHost.Text.ToString(),
                From = txtFrom.Text.ToString(),
                Password = txtPassword.Text.ToString(),
                Subject = txtSubject.Text.ToString(),
                To = txtTo.Text.ToString(),
                Username = txtUsername.Text.ToString()
            };
        }
        public void SendEmail()
        {
            if (String.IsNullOrEmpty(txtTo.Text) || String.IsNullOrEmpty(txtFrom.Text))
                return;
            DialogResult dialogResult = MessageBox.Show("Do you want to continue sending the email?", "Testing Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    MailMessage mail = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    mail.To.Add(_emailNotification.To);
                    mail.From = new MailAddress(_emailNotification.From);
                    mail.Subject = _emailNotification.Subject;
                    mail.Body = _emailNotification.Body;
                    mail.IsBodyHtml = true;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Credentials = new NetworkCredential(_emailNotification.From, _emailNotification.Password);
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Mail has been sent!", "Testing Notification", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Testing Notification", MessageBoxButtons.OK);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do Nothing. . .
            }
        }
        private void SetResults()
        {
            lblEnableSsl.Text = _emailNotification.EnableSsl.Value.ToString();
            lblIsBodyHtml.Text = _emailNotification.IsBodyHtml.ToString();

            lblEmailNotificationId.Text = _emailNotification.EmailNotificationId.ToString();
            lblPort.Text = _emailNotification.Port.Value.ToString();

            lblBcc.Text = _emailNotification.Bcc;
            lblBody.Text = _emailNotification.Body;
            lblCC.Text = _emailNotification.CC;
            lblHost.Text = _emailNotification.Host;
            lblFrom.Text = _emailNotification.From;
            lblPassword.Text = _emailNotification.Password;
            lblSubject.Text = _emailNotification.Subject;
            lblTo.Text = _emailNotification.To;
            lblUsername.Text = _emailNotification.Username;
        }
    }
}
