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
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access Database\MusicStore.accdb;
                                            Persist Security Info=False;");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        
        // Inserting new item in the Database
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                // Checking if all the fields are filled or not
                if ((txt_Album_Name.Text == "")||(txt_Band_Name.Text == "")||(txt_Price.Text == "")||
                    (txt_Stocks.Text == "")||(txt_Url.Text == ""))
                {
                    MessageBox.Show("Please fill all the fields!");
                    connection.Close();
                    return;
                }
                //Checking whether the price field is numeric or not
                double parsedPriceValue;
                if (!double.TryParse(txt_Price.Text, out parsedPriceValue))
                {
                    MessageBox.Show("Please enter proper price of the item!");
                    connection.Close();
                    return;
                }
                //Checking whether the stocks field is numeric or not
                int parsedStockValue;
                if (!int.TryParse(txt_Stocks.Text, out parsedStockValue))
                {
                    MessageBox.Show("Please enter proper Number of stocks left!");
                    connection.Close();
                    return;
                }     
                cmd.CommandText = "insert into MusicStock(Album_Name,Band_Name,Price,Stocks_Left,Image_Url) values ('" + txt_Album_Name.Text + "', '" + txt_Band_Name.Text + "', '" + txt_Price.Text + "', '" + txt_Stocks.Text + "', '" + txt_Url.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Inserted");
                connection.Close();
                tableLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }

        // Function for Refreshing the Data Table
        public void tableLoad()
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Album_Name, Band_Name, Price, Stocks_Left from MusicStock";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                Items_List.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }
    }
}
