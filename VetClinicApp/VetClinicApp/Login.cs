using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Configuration;
using System.Collections.Specialized;
using MySql.Data.MySqlClient;
using MySql;

namespace VetClinicApp
{
    public partial class Login : Form
    {
        private string myConnString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        public bool isLoggedIn = false;
        public Login()
        {
            InitializeComponent();
            Paint += new PaintEventHandler(set_background);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(245, 15, 61), Color.FromArgb(153, 0, 204), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void ConnectToDB()
        {
            // Do SQL stuff here bro!
            MySqlConnection con = new MySqlConnection(myConnString);
            try
            {
                con.Open();
                Console.WriteLine("You are now connected.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Database Connection Error. Notify Administrator.");
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please enter your username.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            // Query SQL Employee for login
            try 
            {
                ValidateLogin(txtUserName.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Login Error");
            }
        }

        private bool ValidateLogin(string user, string pass)
        {
            MySqlConnection con = new MySqlConnection(myConnString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Employees where username=@UserName and password=@Password";
            cmd.Parameters.AddWithValue("@UserName", user);
            cmd.Parameters.AddWithValue("@Password", pass);

            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                Properties.Settings.Default.UserName = user;
                con.Close();
                this.Close();
                isLoggedIn = true;
                Properties.Settings.Default.Save();
                return true;
            }
            else
            {
                con.Close();
                MessageBox.Show("Please check your username or password.","Invalid Login");
                return false;
            }
        }
    }
}
