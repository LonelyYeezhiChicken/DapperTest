using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class clientDetail
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public Nullable<System.DateTime> CreatTime { get; set; }
        public string Item_Name { get; set; }
        public Nullable<int> Item_Amount { get; set; }
        public Nullable<int> Item_Count { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> Total_Amount { get; set; }
        public Nullable<bool> Credit { get; set; }
        public Nullable<int> Credit_no { get; set; }
    }
}
