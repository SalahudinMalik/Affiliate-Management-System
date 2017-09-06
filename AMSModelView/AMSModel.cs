using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSModelView
{
    public class AMSModel
    {
        public int Referral_ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Nullable<int> Comm_Level { get; set; }
    }
}
