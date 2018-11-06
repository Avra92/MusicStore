namespace MusicStore
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Display = new System.Windows.Forms.Label();
            this.dt_ItemsList = new System.Windows.Forms.DataGridView();
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.lb_Album = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Album = new System.Windows.Forms.TextBox();
            this.txt_Band = new System.Windows.Forms.TextBox();
            this.dt_ItemSelected = new System.Windows.Forms.DataGridView();
            this.lb_Cost = new System.Windows.Forms.Label();
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.btn_Purchase = new System.Windows.Forms.Button();
            this.pb_AlbumPic = new System.Windows.Forms.PictureBox();
            this.lb_Price = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lb_DisplayMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ItemsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ItemSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AlbumPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Display
            // 
            this.lb_Display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Display.AutoSize = true;
            this.lb_Display.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Display.ForeColor = System.Drawing.Color.Khaki;
            this.lb_Display.Location = new System.Drawing.Point(11, 19);
            this.lb_Display.Name = "lb_Display";
            this.lb_Display.Size = new System.Drawing.Size(284, 19);
            this.lb_Display.TabIndex = 0;
            this.lb_Display.Text = "Please select an item you want to purchase";
            // 
            // dt_ItemsList
            // 
            this.dt_ItemsList.AllowUserToAddRows = false;
            this.dt_ItemsList.AllowUserToDeleteRows = false;
            this.dt_ItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_ItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_ItemsList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt_ItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_ItemsList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dt_ItemsList.Location = new System.Drawing.Point(3, 41);
            this.dt_ItemsList.Name = "dt_ItemsList";
            this.dt_ItemsList.ReadOnly = true;
            this.dt_ItemsList.Size = new System.Drawing.Size(1054, 184);
            this.dt_ItemsList.TabIndex = 1;
            this.dt_ItemsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_ItemsList_CellClick);
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddToCart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddToCart.Location = new System.Drawing.Point(381, 659);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(91, 23);
            this.btn_AddToCart.TabIndex = 2;
            this.btn_AddToCart.Text = "Add to Cart";
            this.btn_AddToCart.UseVisualStyleBackColor = false;
            this.btn_AddToCart.Visible = false;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // lb_Album
            // 
            this.lb_Album.AutoSize = true;
            this.lb_Album.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Album.ForeColor = System.Drawing.Color.Khaki;
            this.lb_Album.Location = new System.Drawing.Point(12, 247);
            this.lb_Album.Name = "lb_Album";
            this.lb_Album.Size = new System.Drawing.Size(47, 17);
            this.lb_Album.TabIndex = 3;
            this.lb_Album.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Band";
            // 
            // txt_Album
            // 
            this.txt_Album.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Album.Location = new System.Drawing.Point(70, 242);
            this.txt_Album.Name = "txt_Album";
            this.txt_Album.Size = new System.Drawing.Size(402, 22);
            this.txt_Album.TabIndex = 5;
            // 
            // txt_Band
            // 
            this.txt_Band.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Band.Location = new System.Drawing.Point(70, 285);
            this.txt_Band.Name = "txt_Band";
            this.txt_Band.Size = new System.Drawing.Size(402, 22);
            this.txt_Band.TabIndex = 6;
            // 
            // dt_ItemSelected
            // 
            this.dt_ItemSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_ItemSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_ItemSelected.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt_ItemSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_ItemSelected.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_ItemSelected.Location = new System.Drawing.Point(507, 285);
            this.dt_ItemSelected.Name = "dt_ItemSelected";
            this.dt_ItemSelected.ReadOnly = true;
            this.dt_ItemSelected.Size = new System.Drawing.Size(543, 327);
            this.dt_ItemSelected.TabIndex = 7;
            this.dt_ItemSelected.Visible = false;
            this.dt_ItemSelected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_ItemSelected_CellClick);
            // 
            // lb_Cost
            // 
            this.lb_Cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Cost.AutoSize = true;
            this.lb_Cost.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cost.ForeColor = System.Drawing.Color.Khaki;
            this.lb_Cost.Location = new System.Drawing.Point(788, 628);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(117, 17);
            this.lb_Cost.TabIndex = 8;
            this.lb_Cost.Text = "Total Cost in NZD";
            this.lb_Cost.Visible = false;
            // 
            // txt_Cost
            // 
            this.txt_Cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cost.Location = new System.Drawing.Point(906, 625);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(130, 20);
            this.txt_Cost.TabIndex = 9;
            this.txt_Cost.Visible = false;
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Purchase.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Purchase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Purchase.Location = new System.Drawing.Point(906, 659);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(130, 23);
            this.btn_Purchase.TabIndex = 10;
            this.btn_Purchase.Text = "Purchase";
            this.btn_Purchase.UseVisualStyleBackColor = false;
            this.btn_Purchase.Visible = false;
            // 
            // pb_AlbumPic
            // 
            this.pb_AlbumPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_AlbumPic.Location = new System.Drawing.Point(12, 364);
            this.pb_AlbumPic.Name = "pb_AlbumPic";
            this.pb_AlbumPic.Size = new System.Drawing.Size(460, 281);
            this.pb_AlbumPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_AlbumPic.TabIndex = 11;
            this.pb_AlbumPic.TabStop = false;
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.ForeColor = System.Drawing.Color.Khaki;
            this.lb_Price.Location = new System.Drawing.Point(12, 333);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(39, 17);
            this.lb_Price.TabIndex = 12;
            this.lb_Price.Text = "Price";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(70, 330);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(402, 20);
            this.txt_Price.TabIndex = 13;
            // 
            // lb_DisplayMessage
            // 
            this.lb_DisplayMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_DisplayMessage.AutoSize = true;
            this.lb_DisplayMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DisplayMessage.ForeColor = System.Drawing.Color.Khaki;
            this.lb_DisplayMessage.Location = new System.Drawing.Point(504, 242);
            this.lb_DisplayMessage.Name = "lb_DisplayMessage";
            this.lb_DisplayMessage.Size = new System.Drawing.Size(278, 19);
            this.lb_DisplayMessage.TabIndex = 14;
            this.lb_DisplayMessage.Text = "Below items have been added to your cart";
            this.lb_DisplayMessage.Visible = false;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1062, 694);
            this.Controls.Add(this.lb_DisplayMessage);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.pb_AlbumPic);
            this.Controls.Add(this.btn_Purchase);
            this.Controls.Add(this.txt_Cost);
            this.Controls.Add(this.lb_Cost);
            this.Controls.Add(this.dt_ItemSelected);
            this.Controls.Add(this.txt_Band);
            this.Controls.Add(this.txt_Album);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Album);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.dt_ItemsList);
            this.Controls.Add(this.lb_Display);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_ItemsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ItemSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AlbumPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Display;
        private System.Windows.Forms.DataGridView dt_ItemsList;
        private System.Windows.Forms.Button btn_AddToCart;
        private System.Windows.Forms.Label lb_Album;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Album;
        private System.Windows.Forms.TextBox txt_Band;
        private System.Windows.Forms.DataGridView dt_ItemSelected;
        private System.Windows.Forms.Label lb_Cost;
        private System.Windows.Forms.TextBox txt_Cost;
        private System.Windows.Forms.Button btn_Purchase;
        private System.Windows.Forms.PictureBox pb_AlbumPic;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label lb_DisplayMessage;
    }
}