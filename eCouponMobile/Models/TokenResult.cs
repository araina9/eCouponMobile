using Newtonsoft.Json;

namespace eCouponMobile.Models
{
    public class TokenResult
    {
        public string Url { get; set; }
        public string Result { get; set; }
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string userName { get; set; }
        [JsonProperty(".issued")]
        public string issued { get; set; }
        [JsonProperty(".expires")]
        public string expires { get; set; }
    }
}