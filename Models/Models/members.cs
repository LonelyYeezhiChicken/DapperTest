using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class members
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Car_No { get; set; }
        public Nullable<int> Phone { get; set; }
        public Nullable<bool> Credit { get; set; }
        public Nullable<int> Credit_no { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<bool> Enable { get; set; }
        public string Memo { get; set; }
    }
}
