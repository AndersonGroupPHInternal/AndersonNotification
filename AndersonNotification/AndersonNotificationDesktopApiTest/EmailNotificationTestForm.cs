using AccountExternalModel;
using AndersonNotificationModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndersonNotificationDesktopApiTest
{
    public partial class EmailNotificationTestForm : Form
    {
        private EmailNotification _emailNotification;
        public EmailNotificationTestForm()
        {
            InitializeComponent();
        }

        private async void btnLoggedIn_Click(object sender, EventArgs e)
        {
            EmailNotification();
            await Task.Run(() => TestLoggedIn());
            SetResults();
        }

        private async void btnLoggedOut_Click(object sender, EventArgs e)
        {
            EmailNotification();
            await Task.Run(() => TestLoggedOut());
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

        private async Task TestLoggedIn()
        {
            using (var httpClient = new HttpClient())
            {
                var apiCredential = new ApiCredential
                {
                    grant_type = "password",
                    Username = "admin",
                    Password = "password",
                };

                //var tokenAuthentication = JsonConvert.SerializeObject(apiCredential);
                //var tokenBuffer = Encoding.UTF8.GetBytes(tokenAuthentication);
                //var tokenByteContent = new ByteArrayContent(tokenBuffer);
                //tokenByteContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                //var tokenResponse = await httpClient.PostAsync(new Uri("http://localhost:61978/token"), tokenByteContent);
                //var token = tokenResponse.Content.ReadAsStringAsync().Result;

                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:61978");
                var request = new HttpRequestMessage(HttpMethod.Post, "/token");

                var keyValues = new List<KeyValuePair<string, string>>();
                keyValues.Add(new KeyValuePair<string, string>("grant_type", "password"));
                keyValues.Add(new KeyValuePair<string, string>("Username", "admin"));
                keyValues.Add(new KeyValuePair<string, string>("Password", "password"));

                request.Content = new FormUrlEncodedContent(keyValues);
                var response = await client.SendAsync(request);
                var tokenDetails = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content.ReadAsStringAsync().Result);
                var tokenNo = tokenDetails.FirstOrDefault().Value;
            }
        }

        private async Task TestLoggedOut()
        {
            using (var httpClient = new HttpClient())
            {
                var myContent = JsonConvert.SerializeObject(_emailNotification);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await httpClient.PostAsync(new Uri("http://localhost:61978/api/TestApi/LoggedOut"), byteContent);
                _emailNotification = response.Content.ReadAsAsync<EmailNotification>(new[] { new JsonMediaTypeFormatter() }).Result;
            }
        }
    }
}
