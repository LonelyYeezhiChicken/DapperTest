using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public  class items
    {
        public int Id { get; set; }
        public string item_Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> Low_item { get; set; }
        public Nullable<int> Cost_Amount { get; set; }
        public Nullable<int> Sale_Amount { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> die_Count { get; set; }
        public Nullable<int> die_Amount { get; set; }
        public string KindCode { get; set; }
        public string Kind { get; set; }
        public string Car_Kind { get; set; }
        public Nullable<int> Discont_Amount { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string Memo { get; set; }
        public Nullable<bool> Enable { get; set; }
    }
}
