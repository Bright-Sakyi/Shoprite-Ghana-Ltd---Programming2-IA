using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite_Ghana_Ltd
{
    public partial class AttendantForm : Form
    {
        public AttendantForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spyro\source\repos\Shoprite Ghana Ltd\Shoprite Ghana Ltd\shopritedb.mdf;Integrated Security=True;");
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Categoriesbtn_Click(object sender, EventArgs e)
        {
            CategoryForm Cat = new CategoryForm();
            Cat.Show();
            this.Hide();
        }

        private void Sellingbtn_Click(object sender, EventArgs e)
        {
            SellingForm sell = new SellingForm();
            sell.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AttendantsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AttendantId.Text = AttendantsDGV.SelectedRows[0].Cells[0].Value.ToString();
            AttendantName.Text = AttendantsDGV.SelectedRows[0].Cells[1].Value.ToString();
            AttendantAge.Text = AttendantsDGV.SelectedRows[0].Cells[2].Value.ToString();
            AttendantPhone.Text = AttendantsDGV.SelectedRows[0].Cells[3].Value.ToString();
            AttendantPassword.Text = AttendantsDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SellerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void SellerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SellerAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void SellerPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SellerPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into AttendantTbl values(" + AttendantId.Text + ",'" + AttendantName.Text + "'," + AttendantAge.Text + "," + AttendantPhone.Text + ",'" + AttendantPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendant Added Successfully");
                Con.Close();
                populate();
                AttendantId.Text = "";
                AttendantName.Text = "";
                AttendantAge.Text = "";
                AttendantPhone.Text = "";
                AttendantPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttendantId.Text == "" || AttendantName.Text == "" || AttendantAge.Text == "" || AttendantPhone.Text == "" || AttendantPassword.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    Con.Open();
                    string query = "update AttendantTbl set AttendantName='" + AttendantName.Text + "',AttendantAge=" + AttendantAge.Text + ",AttendantPhone=" + AttendantPhone.Text + ",AttendantPassword=" + AttendantPassword.Text + " where AttendantId=" + AttendantId.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Successfully Updated");
                    Con.Close();
                    populate();
                    AttendantId.Text = "";
                    AttendantName.Text = "";
                    AttendantAge.Text = "";
                    AttendantPhone.Text = "";
                    AttendantPassword.Text = "";
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
                if (AttendantId.Text == "")
                {
                    MessageBox.Show("Select the Attendant to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from AttendantTbl where AttendantId=" + AttendantId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendant Deleted Successfully");
                    Con.Close();
                    populate();
                    AttendantId.Text = "";
                    AttendantName.Text = "";
                    AttendantAge.Text = "";
                    AttendantPhone.Text = "";
                    AttendantPassword.Text = "";
                }
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

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            ProductForm Prod = new ProductForm();
            Prod.Show();
            this.Hide();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from AttendantTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendantsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AttendantForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void AttendantsDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AttendantId.Text = AttendantsDGV.SelectedRows[0].Cells[0].Value.ToString();
            AttendantName.Text = AttendantsDGV.SelectedRows[0].Cells[1].Value.ToString();
            AttendantAge.Text = AttendantsDGV.SelectedRows[0].Cells[2].Value.ToString();
            AttendantPhone.Text = AttendantsDGV.SelectedRows[0].Cells[3].Value.ToString();
            AttendantPassword.Text = AttendantsDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
