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
    public partial class Register : Form
    {
        int numberOfResults;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access Database\User.accdb;
                                            Persist Security Info=False;");
        public Register()
        {
            InitializeComponent();
        }

        private void btn_ExistingUser_Click(object sender, EventArgs e)
        {
            //Users with an account are directed to the login page
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            
                
                //Checking whether all the registration fields are filled or not
                if ((txt_Username.Text == "") || (txt_Password.Text == "") || (txt_ConfirmPass.Text == ""))
                {
                    MessageBox.Show("Please fill all the fields!");
                    connection.Close();
                    return;
                }
                //Checking whether th password and confirm  password field matches or not
                if (txt_Password.Text != txt_ConfirmPass.Text)
                {
                    MessageBox.Show("Please ensure you type the passwords correctly!");
                    connection.Close();
                    return;
                }
                CheckExistingUser();
                InsertNewUser();
        }

        public void CheckExistingUser()
        {
            OleDbCommand cmd = new OleDbCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [User] where Username='" + txt_Username.Text + "'";
            numberOfResults = 0;

            using (OleDbDataReader myReader = cmd.ExecuteReader())
            {
                while (myReader != null && myReader.Read())
                {
                    numberOfResults++;
                }
            }

            // If Username already exists in the Database below if condition will be true
            if (numberOfResults > 0)
            {
                MessageBox.Show("Username exists please try a new username!");
                connection.Close();
                return;
            }
            connection.Close();
        }
        
        public void InsertNewUser()
        {
            if(numberOfResults == 0)
            {
                connection.Open();
                OleDbCommand cmd;
                var userType = "Normal User";
                try
                {
                    //Inserting the registration details for the new user
                    cmd = new OleDbCommand("Insert Into [User]([Username], [Password], [UserType]) values (@UserNameParam, @PassParam, @UserTypeParm)", connection);

                    cmd.Parameters.AddWithValue("@UserNameParam", txt_Username.Text);
                    cmd.Parameters.AddWithValue("@PassParam", txt_Password.Text);
                    cmd.Parameters.AddWithValue("@UserTypeParam", userType);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (MessageBox.Show("Registration Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                    {
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex);
                }
            }
        }
    }
}
