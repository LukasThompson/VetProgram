using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace VetClinicApp
{
    public partial class Home : Form
    {
        private string myConnString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            InsertCurrentDate();
        }

        public void InsertCurrentDate()
        {
            Text = "Vet Clinic, Welcome " + DateTime.Now.ToString("yyyy.MM.dd");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                // SQL Query by Phone
                try
                {
                    MySqlConnection con = new MySqlConnection(myConnString);
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Select * from PetOwner where phonenumber=@PhoneNumber";
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        con.Close();
                        //return true;
                        var clientInfo = new ClientInformation();
                        clientInfo.Show();
                    }
                    else
                    {
                        con.Close();
                        //return false;
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.ToString(), "Invalid Characters");
                }
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter a client name or phone number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtFirstName.Focus();
                return;
            }
            else
            {
                try { 
                // SQL Query by First and Last Name
                MySqlConnection con = new MySqlConnection(myConnString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from PetOwner where firstname=@FirstName and lastname=@LastName";
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    con.Close();
                    //return true;
                    var clientInfo = new ClientInformation();
                    clientInfo.Show();
                }
                else
                {
                    con.Close();
                    //return false;
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Invalid Characters");
            }
        }

        }
    }
}
