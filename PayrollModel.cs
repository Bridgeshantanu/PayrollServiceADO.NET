using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollServiceADO.NET
{
    internal class PayrollModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public DateTime start_date { get; set; }
    }
}
