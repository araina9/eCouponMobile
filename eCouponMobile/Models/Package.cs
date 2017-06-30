
namespace eCouponMobile.Models
{
    public class Package
    {
        public int ID { get; set; }
        public string CODE { get; set; }
        public string PKGCODE { get; set; }
        public string NAME { get; set; }
        public string ACTIVEDATE { get; set; }
        public string EXPIREDDATE { get; set; }
        public string CREATED_DATETIME { get; set; }
        public int? MAXUSAGETIME { get; set; }
        public decimal? NORMAL_PRICE { get; set; }
        public decimal? SELLING_PRICE { get; set; }
        public int? DISCOUNT_QTY { get; set; }
        public decimal? DISCOUNT_PRICE { get; set; }
}
}