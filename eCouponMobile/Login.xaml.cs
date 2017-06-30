using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace eCouponMobile
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public void OnLogin(object o, EventArgs s)
        {
            string token = "";
            var vname = txtUserName.Text;
            var vpassword = txtPassword.Text;

            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", vname),
                new KeyValuePair<string, string>("password", vpassword),
            };


            var content = new FormUrlEncodedContent(pairs);

            using(var client = new HttpClient())
            {
                var response = client.PostAsync("https://ecoupon.bdms.co.th/ecouponapi/Token", content).Result;
                var parsedJson = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                token = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }


        }
    }
}
