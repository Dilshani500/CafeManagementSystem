using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.AnimatorNS;

namespace CafeSystem
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dilshani\OneDrive\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "select * from ItemTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        void filterbycategory()
        {
            Con.Open();
            string query = "select * from ItemTb1 where Itemcat = '"+categorycb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Item = new ItemsForm();
            Item.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
        }

        int num = 0;
        int price, total;
        string item, cat;

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("What is the Quantity of item?");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select The Product To be Ordered");
            }
            else
            {
                num = num + 1;
                total = price *  Convert.ToInt32(QtyTb.Text);
                table.Rows.Add(num, item, cat, price,total);
                OrdersGv.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            OrderAmt.Text = ""+sum;
        }

        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into OrdersTb1 values(" + OrderNum.Text + ",'" + Datelb1.Text + "','" + SellerName.Text + "'," + OrderAmt.Text + ")";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully Created");
            Con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGv.DataSource = table;
            Datelb1.Text = DateTime.Today.Date.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            SellerName.Text = Form1.user;
        }
        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;

        }

       

        
        

        

        
    }
}
