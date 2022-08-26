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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spyro\source\repos\Shoprite Ghana Ltd\Shoprite Ghana Ltd\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTbl values(" + CategoryId.Text + ",'" + CategoryName.Text + "','" + CategoryDescription.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
                populate();
                CategoryId.Text = "";
                CategoryName.Text = "";
                CategoryDescription.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CategoryName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CategoryDescription.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoryId.Text == "" || CategoryName.Text == "" || CategoryDescription.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CategoryName='" + CategoryName.Text + "',CategoryDescription='" + CategoryDescription.Text + "' where CategoryId=" + CategoryId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been updated Successfully");
                    Con.Close();
                    populate();
                    CategoryId.Text = "";
                    CategoryName.Text = "";
                    CategoryDescription.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoryId.Text == "")
                {
                    MessageBox.Show("Select Category Id to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where CategoryId=" + CategoryId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been deleted successfully");
                    Con.Close();
                    populate();
                    CategoryId.Text = "";
                    CategoryName.Text = "";
                    CategoryDescription.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void Attendantsbtn_Click(object sender, EventArgs e)
        {
            AttendantForm Attend = new AttendantForm();
            Attend.Show();
            this.Hide();
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            ProductForm Prod = new ProductForm();
            Prod.Show();
            this.Hide();
        }

        private void sellingbtn_Click(object sender, EventArgs e)
        {
            SellingForm sales = new SellingForm();
            sales.Show();
            this.Hide();
        }
    }
}
