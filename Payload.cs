using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SendyApp
{
    class Payload
    {
        [JsonProperty("command")]
        public string command { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonProperty("api_key")]
        public string key { get; set; }

        [JsonProperty("api_username")]
        public string uName { get; set; }
    
        [JsonProperty("from")]
        public From From { get; set; }

        [JsonProperty("to")]
        public TO TO { get; set; }

        [JsonProperty("recepient")]
        public Rec Rec { get; set; }

        [JsonProperty("delivery_details")]
        public Del Del { get; set; }
    }

    public class TO
    {
        [JsonProperty("to_name")]
        public string tname { get; set; }

        [JsonProperty("to_lat")]
        public double tlat { get; set; }

        [JsonProperty("to_long")]
        public double tlong { get; set; }

        [JsonProperty("to_description")]
        public string ttype { get; set; }
    }

    public class Rec
    {
        [JsonProperty("recepient_name")]
        public string recName { get; set; }

        [JsonProperty("recepient_phone")]
        public string recPhone { get; set; }

        [JsonProperty("recepient_email")]
        public string recEmail { get; set; }
    }

    public class From
    {
        [JsonProperty("from_name")]
        public string fname { get; set; }

        [JsonProperty("from_lat")]
        public double flat { get; set; }

        [JsonProperty("from_long")]
        public double flong { get; set; }

        [JsonProperty("from_description")]
        public string ftype { get; set; }
    }

    public class Del
    {
        [JsonProperty("pick_up_date")]
        public string pDate { get; set; }

        [JsonProperty("collect_payment")]
        public colP colP { get; set; }

        [JsonProperty("return")]
        public bool ret { get; set; }

        [JsonProperty("note")]
        public string sample { get; set; }

        [JsonProperty("note_status")]
        public bool noteStat { get; set; }

        [JsonProperty("request_type")]
        public string req { get; set; }
    }

    public class colP
    {
        [JsonProperty("status")]
        public bool stat { get; set; }

        [JsonProperty("pay_method")]
        public int payMeth { get; set; }

        [JsonProperty("amount")]
        public int amount { get; set; }
    }
}
