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

namespace Shoprite_Ghana_Ltd
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spyro\source\repos\Shoprite Ghana Ltd\Shoprite Ghana Ltd\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void FillCategory()
        {
            //This Method will bind the Combobox with the Database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CategoryName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(rdr);
            Categorysearch.ValueMember = "CategoryName";
            Categorysearch.DataSource = dt;
            Categorybox.ValueMember = "CategoryName";
            Categorybox.DataSource = dt;
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillCategory();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductTbl values(" + ProductId.Text + ",'" + ProductName.Text + "'," + Quantity.Text + "," + Price.Text + ",'" + Categorybox.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
                populate();
                ProductId.Text = "";
                ProductName.Text = "";
                Quantity.Text = "";
                Price.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductId.Text = ProductDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            Quantity.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            Price.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            Categorybox.SelectedValue = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductId.Text == "" || ProductName.Text == "" || Quantity.Text == "" || Price.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    Con.Open();
                    string query = "update ProductTbl set ProductName='" + ProductName.Text + "',Quantity=" + Quantity.Text + ",Price=" +  Price.Text + ",Category='" + Categorybox.SelectedValue.ToString() + "' where ProductId=" + ProductId.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    Con.Close();
                    populate();
                    ProductId.Text = "";
                    ProductName.Text = "";
                    Quantity.Text = "";
                    Price.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductId.Text == "")
                {
                    MessageBox.Show("Select the Product to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTbl where ProductId=" + ProductId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    Con.Close();
                    populate();
                    ProductId.Text = "";
                    ProductName.Text = "";
                    Quantity.Text = "";
                    Price.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Categorysearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from ProductTbl where Category='" + Categorysearch.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
