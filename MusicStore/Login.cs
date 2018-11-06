using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MusicStore
{
    public partial class Login : Form
    {
        string userType;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access Database\User.accdb;
                                            Persist Security Info=False;");
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [User] where Username='" + txt_username.Text + "' AND Password='" + txt_password.Text + "'";
            var numberOrResults = 0;

            using (OleDbDataReader myReader = cmd.ExecuteReader())
            {
                while (myReader != null && myReader.Read())
                {
                    numberOrResults++;
                    userType = myReader["UserType"].ToString();
                }
            }

            // If only one result was returned by the database => Succesful login
            if (numberOrResults == 1)
            {
                // Admin Users will be directed to Form1 while others will be directed to Purchase Page
                if(userType == "Admin")
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    this.Hide();
                    Purchase purchase = new Purchase();
                    purchase.Show();
                }
            }

            // No match was found in the database => Failed login
            else if (numberOrResults == 0)
            {
                MessageBox.Show("Invalid Login! Username and Password do not match");
            }
            connection.Close();
        }

        // New Users can create an account by clicking the Register button
        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
