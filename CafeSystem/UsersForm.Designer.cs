namespace CafeSystem
{
    partial class UsersForm
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
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpassTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.UphoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UsersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(119, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 39);
            this.button5.TabIndex = 28;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(209, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 27;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(607, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 37);
            this.label8.TabIndex = 26;
            this.label8.Text = "Users List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "User Name";
            // 
            // UpassTb
            // 
            this.UpassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpassTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UpassTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpassTb.HintForeColor = System.Drawing.Color.Empty;
            this.UpassTb.HintText = "";
            this.UpassTb.isPassword = false;
            this.UpassTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.UpassTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.UpassTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UpassTb.LineThickness = 3;
            this.UpassTb.Location = new System.Drawing.Point(157, 291);
            this.UpassTb.Margin = new System.Windows.Forms.Padding(4);
            this.UpassTb.Name = "UpassTb";
            this.UpassTb.Size = new System.Drawing.Size(154, 34);
            this.UpassTb.TabIndex = 21;
            this.UpassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UphoneTb
            // 
            this.UphoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UphoneTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UphoneTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UphoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.UphoneTb.HintText = "";
            this.UphoneTb.isPassword = false;
            this.UphoneTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.UphoneTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.UphoneTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UphoneTb.LineThickness = 3;
            this.UphoneTb.Location = new System.Drawing.Point(157, 238);
            this.UphoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.UphoneTb.Name = "UphoneTb";
            this.UphoneTb.Size = new System.Drawing.Size(154, 34);
            this.UphoneTb.TabIndex = 15;
            this.UphoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 804);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "LogOut";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UnameTb
            // 
            this.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UnameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UnameTb.HintForeColor = System.Drawing.Color.Empty;
            this.UnameTb.HintText = "";
            this.UnameTb.isPassword = false;
            this.UnameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.UnameTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.UnameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UnameTb.LineThickness = 3;
            this.UnameTb.Location = new System.Drawing.Point(157, 186);
            this.UnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(154, 34);
            this.UnameTb.TabIndex = 14;
            this.UnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UsersGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UsersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersGV.ColumnHeadersHeight = 25;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGV.Location = new System.Drawing.Point(343, 130);
            this.UsersGV.Name = "UsersGV";
            this.UsersGV.RowHeadersVisible = false;
            this.UsersGV.RowHeadersWidth = 51;
            this.UsersGV.RowTemplate.Height = 25;
            this.UsersGV.Size = new System.Drawing.Size(582, 485);
            this.UsersGV.TabIndex = 12;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.UsersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.UsersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UsersGV.ThemeStyle.HeaderStyle.Height = 25;
            this.UsersGV.ThemeStyle.ReadOnly = false;
            this.UsersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersGV.ThemeStyle.RowsStyle.Height = 25;
            this.UsersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.button4.Location = new System.Drawing.Point(28, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 39);
            this.button4.TabIndex = 32;
            this.button4.Text = "Items";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.button3.Location = new System.Drawing.Point(28, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 39);
            this.button3.TabIndex = 31;
            this.button3.Text = "Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1177, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 34);
            this.label6.TabIndex = 30;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(407, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Manage Users";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UpassTb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.UphoneTb);
            this.panel1.Controls.Add(this.UnameTb);
            this.panel1.Controls.Add(this.UsersGV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(203, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 783);
            this.panel1.TabIndex = 29;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1239, 868);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UpassTb;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UphoneTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UnameTb;
        private Guna.UI2.WinForms.Guna2DataGridView UsersGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}