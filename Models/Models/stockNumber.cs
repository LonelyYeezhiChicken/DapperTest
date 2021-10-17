using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public  class stockNumber
    {
        public int Id { get; set; }
        public string CodeName { get; set; }
        public Nullable<int> Item_Number { get; set; }
        public string kind { get; set; }
        public Nullable<int> Type { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}
