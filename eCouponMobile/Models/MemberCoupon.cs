using System.Collections.Generic;

namespace eCouponMobile.Models
{
    public class MemberCoupon
    {
        public Member Member { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Coupon> Coupons { get; set; }
    }
}