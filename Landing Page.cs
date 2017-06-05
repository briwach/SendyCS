using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendyApp
{
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            InitializeComponent();
        }

        private void Landing_Page_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " +Userinfo.Uname, "Login Successful");
            webBrowser1.Url= new Uri(Application.StartupPath + "\\Map.html");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Click += new HtmlElementEventHandler(Document_Click);
        }

        void Document_Click(object sender, HtmlElementEventArgs e)
        {
            if (webBrowser1.Document.ActiveElement.TagName == "BUTTON")
            {
                if (webBrowser1.Document.ActiveElement.Id == "sSet")
                {
                    string sAdd = webBrowser1.Document.GetElementById("sAddress").GetAttribute("value");
                    Userinfo.sAdd = sAdd;
                    oName.Text = sAdd;
                    string sLat = webBrowser1.Document.GetElementById("sLat").GetAttribute("value");
                    Userinfo.sLat = sLat;
                    oLat.Text = sLat;
                    string sLong = webBrowser1.Document.GetElementById("sLon").GetAttribute("value");
                    Userinfo.sLong = sLong;
                    oLong.Text = sLong;
                    string sType = webBrowser1.Document.GetElementById("sType").GetAttribute("value");
                    Userinfo.sType = sType;
                    oType.Text = sType;
                }
                else if (webBrowser1.Document.ActiveElement.Id == "dSet")
                {
                    string dAdd = webBrowser1.Document.GetElementById("dAddress").GetAttribute("value");
                    Userinfo.dAdd = dAdd;
                    dName.Text = dAdd;
                    string dLat = webBrowser1.Document.GetElementById("dLat").GetAttribute("value");
                    Userinfo.dLat = dLat;
                    dlatBox.Text = dLat;
                    string dLong = webBrowser1.Document.GetElementById("dLon").GetAttribute("value");
                    Userinfo.dLong = dLong;
                    dlongBox.Text = dLong;
                    string dType = webBrowser1.Document.GetElementById("dType").GetAttribute("value");
                    Userinfo.dType = dType;
                    dtypeBox.Text = dType;
                }
            }
        }

        private void cnfrmBtn_Click(object sender, EventArgs e)
        {
            if(Userinfo.sAdd==null)
            {
                MessageBox.Show("Please select a valid package origin", "Blank Origin");
            }
            else if(Userinfo.dAdd==null)
            {
                MessageBox.Show("Please select a valid package destination", "Blank Destination");
            }
            else
            {
                Result res = new Result();
                this.Hide();
                res.ShowDialog();
                this.Close();
            }
        }
    }
}
