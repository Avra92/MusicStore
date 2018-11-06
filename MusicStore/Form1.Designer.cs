namespace MusicStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CheckConnection = new System.Windows.Forms.Label();
            this.Items_List = new System.Windows.Forms.DataGridView();
            this.la_Album = new System.Windows.Forms.Label();
            this.la_Band = new System.Windows.Forms.Label();
            this.la_Price = new System.Windows.Forms.Label();
            this.la_Stocks = new System.Windows.Forms.Label();
            this.la_Url = new System.Windows.Forms.Label();
            this.txt_Album_Name = new System.Windows.Forms.TextBox();
            this.txt_Band_Name = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Stocks = new System.Windows.Forms.TextBox();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.la_Display = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lb_DisplayMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Items_List)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckConnection
            // 
            this.CheckConnection.AutoSize = true;
            this.CheckConnection.Location = new System.Drawing.Point(141, 58);
            this.CheckConnection.Name = "CheckConnection";
            this.CheckConnection.Size = new System.Drawing.Size(0, 13);
            this.CheckConnection.TabIndex = 0;
            // 
            // Items_List
            // 
            this.Items_List.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Items_List.AllowUserToAddRows = false;
            this.Items_List.AllowUserToDeleteRows = false;
            this.Items_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Items_List.BackgroundColor = System.Drawing.Color.Black;
            this.Items_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Items_List.DefaultCellStyle = dataGridViewCellStyle4;
            this.Items_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Items_List.Location = new System.Drawing.Point(0, 350);
            this.Items_List.Name = "Items_List";
            this.Items_List.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Items_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Items_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Items_List.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Items_List.Size = new System.Drawing.Size(760, 256);
            this.Items_List.TabIndex = 1;
            // 
            // la_Album
            // 
            this.la_Album.AutoSize = true;
            this.la_Album.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_Album.ForeColor = System.Drawing.Color.Khaki;
            this.la_Album.Location = new System.Drawing.Point(12, 93);
            this.la_Album.Name = "la_Album";
            this.la_Album.Size = new System.Drawing.Size(51, 17);
            this.la_Album.TabIndex = 2;
            this.la_Album.Text = "Album ";
            // 
            // la_Band
            // 
            this.la_Band.AutoSize = true;
            this.la_Band.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_Band.ForeColor = System.Drawing.Color.Khaki;
            this.la_Band.Location = new System.Drawing.Point(12, 135);
            this.la_Band.Name = "la_Band";
            this.la_Band.Size = new System.Drawing.Size(39, 17);
            this.la_Band.TabIndex = 3;
            this.la_Band.Text = "Band";
            // 
            // la_Price
            // 
            this.la_Price.AutoSize = true;
            this.la_Price.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_Price.ForeColor = System.Drawing.Color.Khaki;
            this.la_Price.Location = new System.Drawing.Point(12, 174);
            this.la_Price.Name = "la_Price";
            this.la_Price.Size = new System.Drawing.Size(39, 17);
            this.la_Price.TabIndex = 4;
            this.la_Price.Text = "Price";
            // 
            // la_Stocks
            // 
            this.la_Stocks.AutoSize = true;
            this.la_Stocks.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_Stocks.ForeColor = System.Drawing.Color.Khaki;
            this.la_Stocks.Location = new System.Drawing.Point(12, 214);
            this.la_Stocks.Name = "la_Stocks";
            this.la_Stocks.Size = new System.Drawing.Size(76, 17);
            this.la_Stocks.TabIndex = 5;
            this.la_Stocks.Text = "Stocks Left";
            // 
            // la_Url
            // 
            this.la_Url.AutoSize = true;
            this.la_Url.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_Url.ForeColor = System.Drawing.Color.Khaki;
            this.la_Url.Location = new System.Drawing.Point(12, 251);
            this.la_Url.Name = "la_Url";
            this.la_Url.Size = new System.Drawing.Size(38, 17);
            this.la_Url.TabIndex = 6;
            this.la_Url.Text = "URL";
            // 
            // txt_Album_Name
            // 
            this.txt_Album_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Album_Name.Location = new System.Drawing.Point(131, 90);
            this.txt_Album_Name.Name = "txt_Album_Name";
            this.txt_Album_Name.Size = new System.Drawing.Size(617, 20);
            this.txt_Album_Name.TabIndex = 7;
            // 
            // txt_Band_Name
            // 
            this.txt_Band_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Band_Name.Location = new System.Drawing.Point(131, 132);
            this.txt_Band_Name.Name = "txt_Band_Name";
            this.txt_Band_Name.Size = new System.Drawing.Size(617, 20);
            this.txt_Band_Name.TabIndex = 8;
            // 
            // txt_Price
            // 
            this.txt_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Price.Location = new System.Drawing.Point(131, 171);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(617, 20);
            this.txt_Price.TabIndex = 9;
            // 
            // txt_Stocks
            // 
            this.txt_Stocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Stocks.Location = new System.Drawing.Point(131, 211);
            this.txt_Stocks.Name = "txt_Stocks";
            this.txt_Stocks.Size = new System.Drawing.Size(617, 20);
            this.txt_Stocks.TabIndex = 10;
            // 
            // txt_Url
            // 
            this.txt_Url.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Url.Location = new System.Drawing.Point(131, 251);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(617, 20);
            this.txt_Url.TabIndex = 11;
            // 
            // la_Display
            // 
            this.la_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.la_Display.AutoSize = true;
            this.la_Display.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_Display.ForeColor = System.Drawing.Color.Khaki;
            this.la_Display.Location = new System.Drawing.Point(11, 326);
            this.la_Display.Name = "la_Display";
            this.la_Display.Size = new System.Drawing.Size(178, 21);
            this.la_Display.TabIndex = 12;
            this.la_Display.Text = "List of Items Available";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Add.Location = new System.Drawing.Point(647, 286);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(101, 25);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add Item";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_DisplayMessage
            // 
            this.lb_DisplayMessage.AutoSize = true;
            this.lb_DisplayMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DisplayMessage.ForeColor = System.Drawing.Color.Khaki;
            this.lb_DisplayMessage.Location = new System.Drawing.Point(12, 37);
            this.lb_DisplayMessage.Name = "lb_DisplayMessage";
            this.lb_DisplayMessage.Size = new System.Drawing.Size(549, 21);
            this.lb_DisplayMessage.TabIndex = 14;
            this.lb_DisplayMessage.Text = "Please fill up the below fields for the new item you want to add in store";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(760, 606);
            this.Controls.Add(this.lb_DisplayMessage);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.la_Display);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.txt_Stocks);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Band_Name);
            this.Controls.Add(this.txt_Album_Name);
            this.Controls.Add(this.la_Url);
            this.Controls.Add(this.la_Stocks);
            this.Controls.Add(this.la_Price);
            this.Controls.Add(this.la_Band);
            this.Controls.Add(this.la_Album);
            this.Controls.Add(this.Items_List);
            this.Controls.Add(this.CheckConnection);
            this.Name = "Form1";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Items_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CheckConnection;
        private System.Windows.Forms.DataGridView Items_List;
        private System.Windows.Forms.Label la_Album;
        private System.Windows.Forms.Label la_Band;
        private System.Windows.Forms.Label la_Price;
        private System.Windows.Forms.Label la_Stocks;
        private System.Windows.Forms.Label la_Url;
        private System.Windows.Forms.TextBox txt_Album_Name;
        private System.Windows.Forms.TextBox txt_Band_Name;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Stocks;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Label la_Display;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lb_DisplayMessage;
    }
}

