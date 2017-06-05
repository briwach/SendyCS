using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SendyApp
{
    
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string qString;
        string name;
        string phone;
        string email;

        public Login()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            regGrp.Visible = true;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["AppConnString"].ToString();
            conn = new SqlConnection(connstring);
            conn.Open();
            qString = "";
            qString = "SELECT * FROM UserData WHERE username='" + unameTbox.Text + "' AND password = '" + pwdTbox.Text + "' ";
            cmd = new SqlCommand(qString, conn);

            reader = cmd.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("Name"));
                phone = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                email = reader.GetString(reader.GetOrdinal("Email"));
            }
            if (reader.HasRows)
            {
                Userinfo.Uname = name;
                Userinfo.Phone = phone;
                Userinfo.Email = email;
                Landing_Page cont = new Landing_Page();
                this.Hide();
                cont.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect", "Invalid User");

                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };

                func(Controls);
            }

            reader.Close();
            conn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            regGrp.Visible = false;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Text = "";
            tb.ForeColor = Color.Black;
        }

        private void regGrp_Enter(object sender, EventArgs e)
        {
            foreach (Control ctrl in regGrp.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Enter += txt_Enter;
                }
            }
            
        }

        private void sgnBtn_Click(object sender, EventArgs e)
        {
            string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["AppConnString"].ToString();
            conn = new SqlConnection(connstring);
            conn.Open();
            qString = "";

            qString = "INSERT INTO UserData (Name,PhoneNumber,Email,username,password)" +
                "VALUES('" + regName.Text + "', '" + regPhone.Text + "','" + regEmail.Text + "','" + regUname.Text + "' , '" + regPwd.Text + "')";
            cmd = new SqlCommand(qString, conn);

            cmd.ExecuteReader();

            MessageBox.Show("Please Login with your new Credentials", "Registration Successful");
            conn.Close();
            regGrp.Visible = false;
        }
    }
}
