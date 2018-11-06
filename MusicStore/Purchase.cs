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
    public partial class Purchase : Form

    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access Database\MusicStore.accdb;
                                            Persist Security Info=False;");
        string imageUrl;
        double totalCost = 0;
        int rowCount = 0;

        public Purchase()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        // Allowing the user to select items from the list by clicking on it
        private void dt_ItemsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Album.Text = (dt_ItemsList.Rows[e.RowIndex].Cells[0].Value).ToString();
            txt_Band.Text = (dt_ItemsList.Rows[e.RowIndex].Cells[1].Value).ToString();
            txt_Price.Text = (dt_ItemsList.Rows[e.RowIndex].Cells[2].Value).ToString();
            imageUrl = (dt_ItemsList.Rows[e.RowIndex].Cells[4].Value).ToString();
            pb_AlbumPic.Image = new Bitmap(imageUrl);
            btn_AddToCart.Visible = true;
        }

        public void tableLoad()
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Album_Name, Band_Name, Price, Stocks_Left, Image_Url from MusicStock";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dt_ItemsList.DataSource = dt;
                dt_ItemsList.Columns[4].Visible = false;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        //Setting the DataGridViews when the Purchase form is loaded
        private void Purchase_Load(object sender, EventArgs e)
        {
            tableLoad();
            dt.Columns.Add("Album");
            dt.Columns.Add("Band");
            dt.Columns.Add("Price");
            dt_ItemSelected.DataSource = dt;
            DataGridViewButtonColumn btn_Remove = new DataGridViewButtonColumn();
            btn_Remove.HeaderText = "";
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Text = "Remove";
            btn_Remove.UseColumnTextForButtonValue = true;
            dt_ItemSelected.Columns.Add(btn_Remove);

        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            // Displaying the Items user is adding to cart
            dt_ItemSelected.Visible = true;
            lb_DisplayMessage.Visible = true;
            lb_Cost.Visible = true;
            txt_Cost.Visible = true;
            btn_Purchase.Visible = true;
            dt.Rows.Add(txt_Album.Text, txt_Band.Text, txt_Price.Text);
            dt_ItemSelected.DataSource = dt;
            //Calculating the total cost for the items added in Cart
            totalCost += Convert.ToDouble(dt_ItemSelected.Rows[rowCount].Cells["Price"].Value);
            rowCount++;
            txt_Cost.Text = totalCost.ToString();
        }

        // Removing an Item from the list of Items the user added to his/her cart
        private void dt_ItemSelected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_ItemSelected.Columns[e.ColumnIndex].Name == "btn_Remove")
            {
                if (MessageBox.Show("Are you sure you want to remove this item from cart?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    totalCost = totalCost - Convert.ToDouble(dt_ItemSelected.Rows[e.RowIndex].Cells["Price"].Value);
                    dt_ItemSelected.Rows.RemoveAt(e.RowIndex);
                    txt_Cost.Text = totalCost.ToString();
                    rowCount--;
                }
            }
        }
    }
}
