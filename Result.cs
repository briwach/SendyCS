using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace SendyApp
{
    public partial class Result : Form
    {

        public Result()
        {
            InitializeComponent();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Result_Load(object sender, EventArgs e)
        {
            var payload = init();
            var stringPayload = await Task.Run(() => JsonConvert.SerializeObject(payload));
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Do the actual request and await the response
                    var httpResponse = await httpClient.PostAsync("https://api.sendyit.com/v1/ ", httpContent);

                    if (httpResponse.Content != null)
                    {
                        var responseContent = await httpResponse.Content.ReadAsStringAsync();
                        Output output = JsonConvert.DeserializeObject<Output>(responseContent);
                        oNum.Text = output.data.order_no;
                        amt.Text = output.data.amount.ToString();
                        curr.Text = output.data.currency;
                        dst.Text = output.data.distance;
                        eta.Text = output.data.eta;
                        etd.Text = output.data.etd;
                    }
                }
                catch (WebException ex)
                {
                    using (var stream = ex.Response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Sorry, there appears to be a problem sending the request","Error");
                }
                
            }
               
        }
        private Payload init ()
        {
            var payload = new Payload
            {
                command = "request",
                Data = new Data
                {
                    key = "UBUGBvAhRP7hdeKDWQaR",
                    uName = "bigbizco",
                    From = new From
                    {
                        fname = Userinfo.sAdd,
                        flat = Convert.ToDouble(Userinfo.sLat),
                        flong = Convert.ToDouble(Userinfo.sLong),
                        ftype = Userinfo.sType
                    },
                    TO = new TO
                    {
                        tname = Userinfo.dAdd,
                        tlat = Convert.ToDouble(Userinfo.dLat),
                        tlong = Convert.ToDouble(Userinfo.dLong),
                        ttype = Userinfo.dType
                    },
                    Rec = new Rec
                    {
                        recName = Userinfo.Uname,
                        recPhone = Userinfo.Phone,
                        recEmail = Userinfo.Email
                    },
                    Del = new Del
                    {
                        pDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        colP = new colP
                        {
                            stat = false,
                            payMeth = 0,
                            amount = 10
                        },
                        ret = true,
                        sample = " Sample note",
                        noteStat = true,
                        req = "quote"
                    }
                }
            };
            return payload;
        }

    }
}
