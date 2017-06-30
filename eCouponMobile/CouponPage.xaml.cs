using System;
using System.Collections.Generic;
using eCouponMobile.Models;
using Xamarin.Forms;

namespace eCouponMobile
{
    public partial class CouponPage : ContentPage
    {
        Coupon coupon;
        public CouponPage():base(){}
        public CouponPage(Coupon coupon)
        {
            InitializeComponent();

            this.coupon = coupon;

            msgResult.Text =     "[Coupon Code]\t" + this.coupon.COUPON_CODE
								+ "\n[Event Name]\t\t" + this.coupon.EVENT_NAME
								+ "\n[Package group]\t" + this.coupon.PACKAGEGROUP_NAME
								+ "\n[Package]\t\t\t" + this.coupon.PACKAGE_NAME
								+ "\n[Status]\t\t\t" + this.coupon.STATUS
								+ "\n[Expire Date]\t\t" + this.coupon.DATE_EXPIRED
								+ "\n[Amount]\t\t\t" + this.coupon.AMOUNT
								+ "\n[Total Price]\t\t" + string.Format("{0:C}", this.coupon.TOTAL_PRICE);
        }


		async void OnPreviousPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

    }
}
