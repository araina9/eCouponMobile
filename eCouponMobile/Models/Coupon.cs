
namespace eCouponMobile.Models
{
    public class Coupon
    {
        public int COUPON_ID { get; set; }
        public string COUPON_CODE { get; set; }

        public string ORDER_NO { get; set; }

        public int? MEMBER_ID { get; set; }
        public string MEMBER_USERNAME { get; set; }
        public string MEMBER_NAME { get; set; }

        public string EVENT_CODE { get; set; }
        public string EVENT_NAME { get; set; }

        public string PACKAGEGROUP_CODE { get; set; }
        public string PACKAGEGROUP_NAME { get; set; }

        public string PACKAGE_CODE { get; set; }
        public string PACKAGE_NAME { get; set; }

        public string STATUS { get; set; }
        public string DATE_PURCHASED { get; set; }
        public string DATE_EXPIRED { get; set; }
        public string DATE_USED { get; set; }

        public decimal? TOTAL_PRICE { get; set; } // PRICE
        public int? AMOUNT { get; set; } // QUANTITY
    }
}