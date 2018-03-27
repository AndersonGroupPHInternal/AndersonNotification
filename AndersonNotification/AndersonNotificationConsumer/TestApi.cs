using System.Net.Http;
using System.Threading.Tasks;
using AndersonNotificationModel;
using Newtonsoft.Json;
using System;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace AndersonNotificationConsumer
{
    public class TestApi : ITestApi
    {

        public async Task<EmailNotification> LoggedOut(EmailNotification emailNotification)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var myContent = JsonConvert.SerializeObject(emailNotification);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var response = await httpClient.PostAsync(new Uri(ConfigurationManager.AppSettings["AndersonNotificationUrl"] + "/api/TestApi/LoggedOut"), byteContent);
                    emailNotification = response.Content.ReadAsAsync<EmailNotification>(new[] { new JsonMediaTypeFormatter() }).Result;

                    return emailNotification;
                }
            }
            catch
            {
                return emailNotification;
            }
        }


        public async Task<EmailNotification> LoggedIn(EmailNotification emailNotification)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var clientToken = new HttpClient();
                    clientToken.BaseAddress = new Uri(ConfigurationManager.AppSettings["AndersonNotificationUrl"]);
                    var request = new HttpRequestMessage(HttpMethod.Post, "/token");

                    var keyValues = new List<KeyValuePair<string, string>>();
                    keyValues.Add(new KeyValuePair<string, string>("grant_type", "password"));
                    keyValues.Add(new KeyValuePair<string, string>("Username", ConfigurationManager.AppSettings["AndersonNotificationUsername"]));
                    keyValues.Add(new KeyValuePair<string, string>("Password", ConfigurationManager.AppSettings["AndersonNotificationPassword"]));

                    request.Content = new FormUrlEncodedContent(keyValues);
                    var tokenResponse = await clientToken.SendAsync(request);
                    var tokenDetails = JsonConvert.DeserializeObject<Dictionary<string, string>>(tokenResponse.Content.ReadAsStringAsync().Result);
                    var token = tokenDetails.FirstOrDefault().Value;

                    var myContent = JsonConvert.SerializeObject(emailNotification);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    var response = await httpClient.PostAsync(new Uri(ConfigurationManager.AppSettings["AndersonNotificationUrl"] + "/api/TestApi/LoggedIn"), byteContent);
                    emailNotification = response.Content.ReadAsAsync<EmailNotification>(new[] { new JsonMediaTypeFormatter() }).Result;

                    return emailNotification;
                }
            }
            catch
            {
                return emailNotification;
            }
        }
    }
}
