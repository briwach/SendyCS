using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendyApp
{
    class Output
    {
        public bool status { get; set; }
        public outP data { get; set; }
    }
    public class outP
    {
        public string order_no { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public string distance { get; set; }
        public string eta { get; set; }
        public string etd { get; set; }
        public int amount_return { get; set; }
        public string order_status { get; set; }
        public string pick_up_date { get; set; }
    }
}
