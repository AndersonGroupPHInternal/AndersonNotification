using AndersonNotificationConsumer;
using AndersonNotificationModel;
using System;
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
            EmailNotification();
            _emailNotification = await _iEmailNotificationApi.Create(_emailNotification);
            SetResults();
        }

        private void EmailNotification()
        {
            _emailNotification = new EmailNotification
            {
                EnableSsl = chkEnableSsl.Checked,
                IsBodyHtml = chkIsBodyHtml.Checked,

                EmailNotificationId = Convert.ToInt32(txtEmailNotificationId.Text),
                Port = Convert.ToInt32(txtPort.Text),

                Bcc = txtBcc.Text,
                Body = txtBody.Text,
                CC = txtCC.Text,
                Host = txtHost.Text,
                From = txtFrom.Text,
                Password = txtPassword.Text,
                Subject = txtSubject.Text,
                To = txtTo.Text,
                Username = txtUsername.Text
            };
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
