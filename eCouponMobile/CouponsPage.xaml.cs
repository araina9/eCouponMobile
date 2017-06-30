using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using eCouponMobile.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace eCouponMobile
{
    public partial class CouponsPage : ContentPage
    {
        private string Coupontoken;
        public CouponsPage(): base(){}
		public CouponsPage(string token) 
        {
            InitializeComponent();
            this.Coupontoken = token;

            var result = CallApi("https://ecoupon.bdms.co.th/ecouponapi/api/couponsNew", token);

            MemberCoupon memberCoupon = JsonConvert.DeserializeObject<MemberCoupon>(result);

            var coupons = new ObservableCollection<Coupon>(memberCoupon.Coupons);

            CouponsView.ItemsSource = coupons;
        }

		private void HandleItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
			{
				return;
			}

            CouponDetails((Coupon)e.SelectedItem);
		}

		async void CouponDetails(Coupon coupon)
		{
			await Navigation.PushAsync(new CouponPage(coupon));
		}

		async void OnPreviousPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}


        public string CallApi(string url, string token)
        {
            string result = null;
            using(var client = new HttpClient())
            {
                var t = JsonConvert.DeserializeObject<Token>(token);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", t.token_type + " " + t.access_token);

                var respose = client.GetAsync(url).Result;

                dynamic parsedJson = JsonConvert.DeserializeObject(respose.Content.ReadAsStringAsync().Result);

                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }

            return result;
        }

    }

}
