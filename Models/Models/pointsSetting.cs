using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class pointsSetting
    {
        public int Id { get; set; }
        public int PointCode { get; set; }
        public System.DateTime CreatTime { get; set; }
        public string CreatUser { get; set; }
        public string PointName { get; set; }
        public Nullable<int> MaxPoint { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public Nullable<bool> IsDeadline { get; set; }
        public System.DateTime Deadline { get; set; }
        public string Memo { get; set; }
    }
}
