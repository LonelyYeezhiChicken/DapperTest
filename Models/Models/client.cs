using System;

namespace Models.Models
{
    public class client
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public Nullable<int> MemberId { get; set; }
        public string MemberName { get; set; }
        public Nullable<int> Long { get; set; }
        public System.DateTime CreatTime { get; set; }
        public Nullable<int> Item_Count { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> Total_Amount { get; set; }
        public Nullable<bool> Credit { get; set; }
        public Nullable<int> Credit_no { get; set; }
    }
}