using System;

namespace eCouponMobile.Models
{
    public class UserAccount
    {
        public int ID { get; set; }
        public Nullable<int> DEPARTMENTID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string DISPLAYNAME { get; set; }
        public bool ENABLED { get; set; }
        public int ROLE { get; set; }
        public System.DateTime CREATED_DATETIME { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATETIME { get; set; }
        public string UPDATED_BY { get; set; }
        public bool DELETED { get; set; }
        public string STAFFID { get; set; }
    }
}