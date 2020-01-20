using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PushNotification : ContentPage
    {
        public PushNotification()
        {
            InitializeComponent();
        }
        public void SetToken(String token)
        {
            enToken.Text = token;
        }

        const string FCM_ENDERECO = "https://fcm.googleapis.com/fcm/";
        const string FCM_SERVER_KEY = "AAAAnME5Xt8:APA91bHOegICG3QKcdx-w3nO_4lLqBL7SjOJTS1NL5KVPTQpsStsCuwvnIbDRV26zfufGoqg1wiuc9ghUE1WvjomNOjVnNa_VnClr8s9OeebJDC_4jWkCKU10-IQcl2voC9l-1JZrLRk";

        private void btnSend_Clicked(object sender, EventArgs e)
        {
            string resultado = "";

            string str = "";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(FCM_ENDERECO);

            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.
                TryAddWithoutValidation("Authorization", $"key={FCM_SERVER_KEY}");
             

            var objNotification = new
            {
                //registration_ids = destinatarios.ToArray<string>(),
                to = enToken.Text,//notification.DeviceToken
                data = new
                {
                    tittle = "PLN DJTY",
                    message = enMsg.Text,
                    info1 = "info1"
                }
            };

            str = JsonConvert.SerializeObject(objNotification);

            var postContent = new StringContent(str,
                System.Text.Encoding.UTF8, "application/json");

            btnSend.IsEnabled = false;

            HttpResponseMessage resp = client.PostAsync("send", postContent).Result;

            if (resp.IsSuccessStatusCode)
            {
                var strContent = resp.Content.ReadAsStringAsync().Result;

                resultado = strContent;

                enResp.Text = resultado;
            }

            btnSend.IsEnabled = true;
        }
    }

}