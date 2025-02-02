namespace CafeSystem
{
    partial class GuestOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Datelb1 = new System.Windows.Forms.Label();
            this.QtyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdersGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderAmt = new System.Windows.Forms.Label();
            this.SellerNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OrderNumTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ItemsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Datelb1);
            this.panel1.Controls.Add(this.QtyTb);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrdersGv);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.OrderAmt);
            this.panel1.Controls.Add(this.SellerNameTb);
            this.panel1.Controls.Add(this.OrderNumTb);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.categorycb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(244, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 793);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(598, 713);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Rs";
            // 
            // Datelb1
            // 
            this.Datelb1.AutoSize = true;
            this.Datelb1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelb1.ForeColor = System.Drawing.Color.Black;
            this.Datelb1.Location = new System.Drawing.Point(650, 17);
            this.Datelb1.Name = "Datelb1";
            this.Datelb1.Size = new System.Drawing.Size(56, 23);
            this.Datelb1.TabIndex = 22;
            this.Datelb1.Text = "Date";
            // 
            // QtyTb
            // 
            this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.QtyTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QtyTb.HintForeColor = System.Drawing.Color.Empty;
            this.QtyTb.HintText = "";
            this.QtyTb.isPassword = false;
            this.QtyTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.QtyTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.QtyTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.QtyTb.LineThickness = 3;
            this.QtyTb.Location = new System.Drawing.Point(396, 294);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(4);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(189, 34);
            this.QtyTb.TabIndex = 21;
            this.QtyTb.Text = "Quantity";
            this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(332, 708);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Place The Oder";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(521, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Your Order";
            // 
            // OrdersGv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.OrdersGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrdersGv.ColumnHeadersHeight = 25;
            this.OrdersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrdersGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGv.Location = new System.Drawing.Point(299, 382);
            this.OrdersGv.Name = "OrdersGv";
            this.OrdersGv.RowHeadersVisible = false;
            this.OrdersGv.RowHeadersWidth = 51;
            this.OrdersGv.RowTemplate.Height = 24;
            this.OrdersGv.Size = new System.Drawing.Size(568, 287);
            this.OrdersGv.TabIndex = 18;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrdersGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrdersGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.OrdersGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrdersGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrdersGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrdersGv.ThemeStyle.HeaderStyle.Height = 25;
            this.OrdersGv.ThemeStyle.ReadOnly = false;
            this.OrdersGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrdersGv.ThemeStyle.RowsStyle.Height = 24;
            this.OrdersGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(604, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderAmt
            // 
            this.OrderAmt.AutoSize = true;
            this.OrderAmt.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAmt.ForeColor = System.Drawing.Color.Black;
            this.OrderAmt.Location = new System.Drawing.Point(661, 713);
            this.OrderAmt.Name = "OrderAmt";
            this.OrderAmt.Size = new System.Drawing.Size(191, 34);
            this.OrderAmt.TabIndex = 16;
            this.OrderAmt.Text = "OderAmount";
            // 
            // SellerNameTb
            // 
            this.SellerNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerNameTb.Enabled = false;
            this.SellerNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SellerNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.SellerNameTb.HintText = "";
            this.SellerNameTb.isPassword = false;
            this.SellerNameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.SellerNameTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.SellerNameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SellerNameTb.LineThickness = 3;
            this.SellerNameTb.Location = new System.Drawing.Point(78, 225);
            this.SellerNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.SellerNameTb.Name = "SellerNameTb";
            this.SellerNameTb.Size = new System.Drawing.Size(189, 34);
            this.SellerNameTb.TabIndex = 15;
            this.SellerNameTb.Text = "Guest";
            this.SellerNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // OrderNumTb
            // 
            this.OrderNumTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OrderNumTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OrderNumTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrderNumTb.HintForeColor = System.Drawing.Color.Empty;
            this.OrderNumTb.HintText = "";
            this.OrderNumTb.isPassword = false;
            this.OrderNumTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.OrderNumTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.OrderNumTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.OrderNumTb.LineThickness = 3;
            this.OrderNumTb.Location = new System.Drawing.Point(78, 170);
            this.OrderNumTb.Margin = new System.Windows.Forms.Padding(4);
            this.OrderNumTb.Name = "OrderNumTb";
            this.OrderNumTb.Size = new System.Drawing.Size(189, 34);
            this.OrderNumTb.TabIndex = 14;
            this.OrderNumTb.Text = "OrderNum";
            this.OrderNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ItemsGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ItemsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ItemsGV.ColumnHeadersHeight = 25;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ItemsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsGV.Location = new System.Drawing.Point(315, 88);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowHeadersVisible = false;
            this.ItemsGV.RowHeadersWidth = 51;
            this.ItemsGV.RowTemplate.Height = 24;
            this.ItemsGV.Size = new System.Drawing.Size(568, 185);
            this.ItemsGV.TabIndex = 12;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemsGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ItemsGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ItemsGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemsGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemsGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ItemsGV.ThemeStyle.ReadOnly = false;
            this.ItemsGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsGV.ThemeStyle.RowsStyle.Height = 24;
            this.ItemsGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
            // 
            // categorycb
            // 
            this.categorycb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.categorycb.Location = new System.Drawing.Point(78, 106);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(189, 35);
            this.categorycb.TabIndex = 11;
            this.categorycb.Text = "Category";
            this.categorycb.SelectionChangeCommitted += new System.EventHandler(this.categorycb_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(407, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Place Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1158, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 34);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 943);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "LogOut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 813);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "LogOut";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1239, 868);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.GuestOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categorycb;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OrderNumTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QtyTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersGv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label OrderAmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Datelb1;
        private System.Windows.Forms.Label label1;
    }
}