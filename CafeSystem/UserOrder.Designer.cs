namespace CafeSystem
{
    partial class UserOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderAmt = new System.Windows.Forms.Label();
            this.Datelb1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.QtyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdersGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OrderNum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ItemsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OrderAmt);
            this.panel1.Controls.Add(this.Datelb1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.QtyTb);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrdersGv);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SellerName);
            this.panel1.Controls.Add(this.OrderNum);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.categorycb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(232, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 793);
            this.panel1.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSlateGray;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(585, 726);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 39);
            this.button6.TabIndex = 27;
            this.button6.Text = "View Orders";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(339, 731);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "Rs";
            // 
            // OrderAmt
            // 
            this.OrderAmt.AutoSize = true;
            this.OrderAmt.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAmt.ForeColor = System.Drawing.Color.Black;
            this.OrderAmt.Location = new System.Drawing.Point(388, 731);
            this.OrderAmt.Name = "OrderAmt";
            this.OrderAmt.Size = new System.Drawing.Size(191, 34);
            this.OrderAmt.TabIndex = 25;
            this.OrderAmt.Text = "OderAmount";
            // 
            // Datelb1
            // 
            this.Datelb1.AutoSize = true;
            this.Datelb1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelb1.ForeColor = System.Drawing.Color.Black;
            this.Datelb1.Location = new System.Drawing.Point(659, 17);
            this.Datelb1.Name = "Datelb1";
            this.Datelb1.Size = new System.Drawing.Size(56, 23);
            this.Datelb1.TabIndex = 24;
            this.Datelb1.Text = "Date";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(273, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 39);
            this.button5.TabIndex = 23;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(537, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 34);
            this.label5.TabIndex = 22;
            this.label5.Text = "Place Order";
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
            this.QtyTb.Location = new System.Drawing.Point(491, 344);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(4);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.button2.Location = new System.Drawing.Point(94, 728);
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
            this.label3.Location = new System.Drawing.Point(553, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Your Order";
            // 
            // OrdersGv
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.OrdersGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.OrdersGv.ColumnHeadersHeight = 25;
            this.OrdersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersGv.DefaultCellStyle = dataGridViewCellStyle27;
            this.OrdersGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGv.Location = new System.Drawing.Point(313, 490);
            this.OrdersGv.Name = "OrdersGv";
            this.OrdersGv.RowHeadersVisible = false;
            this.OrdersGv.RowHeadersWidth = 51;
            this.OrdersGv.RowTemplate.Height = 24;
            this.OrdersGv.Size = new System.Drawing.Size(597, 197);
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
            this.OrdersGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button1.Location = new System.Drawing.Point(491, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerName
            // 
            this.SellerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerName.HintForeColor = System.Drawing.Color.Empty;
            this.SellerName.HintText = "";
            this.SellerName.isPassword = false;
            this.SellerName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.SellerName.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.SellerName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SellerName.LineThickness = 3;
            this.SellerName.Location = new System.Drawing.Point(78, 221);
            this.SellerName.Margin = new System.Windows.Forms.Padding(4);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(189, 34);
            this.SellerName.TabIndex = 15;
            this.SellerName.Text = "Seller";
            this.SellerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // OrderNum
            // 
            this.OrderNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OrderNum.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrderNum.HintForeColor = System.Drawing.Color.Empty;
            this.OrderNum.HintText = "";
            this.OrderNum.isPassword = false;
            this.OrderNum.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.OrderNum.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.OrderNum.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.OrderNum.LineThickness = 3;
            this.OrderNum.Location = new System.Drawing.Point(78, 170);
            this.OrderNum.Margin = new System.Windows.Forms.Padding(4);
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.Size = new System.Drawing.Size(189, 34);
            this.OrderNum.TabIndex = 14;
            this.OrderNum.Text = "OderNum";
            this.OrderNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ItemsGV
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.ItemsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.ItemsGV.ColumnHeadersHeight = 30;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGV.DefaultCellStyle = dataGridViewCellStyle30;
            this.ItemsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsGV.Location = new System.Drawing.Point(413, 106);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowHeadersVisible = false;
            this.ItemsGV.RowHeadersWidth = 51;
            this.ItemsGV.RowTemplate.Height = 24;
            this.ItemsGV.Size = new System.Drawing.Size(521, 199);
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
            this.ItemsGV.ThemeStyle.HeaderStyle.Height = 30;
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
            this.categorycb.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
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
            this.label6.Location = new System.Drawing.Point(1164, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 796);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "LogOut";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.button3.Location = new System.Drawing.Point(49, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 39);
            this.button3.TabIndex = 23;
            this.button3.Text = "Items";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.button4.Location = new System.Drawing.Point(49, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 39);
            this.button4.TabIndex = 24;
            this.button4.Text = "Users";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1239, 868);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOrder";
            this.Load += new System.EventHandler(this.UserOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QtyTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersGv;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OrderNum;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsGV;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Datelb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OrderAmt;
        private System.Windows.Forms.Button button6;
    }
}