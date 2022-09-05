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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spyro\source\repos\Shoprite Ghana Ltd\Shoprite Ghana Ltd\shopritedb.mdf;Integrated Security=True;");
        private void populate()
        {
            Con.Open();
            string query = "select ProductName,Quantity from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populatebills()
        {
            Con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void OrdersDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        int Grandtotal = 0, n = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void AddProductbtn_Click(object sender, EventArgs e)
        {
            if (ProdtName.Text == "" || Quantity.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(Price.Text) * Convert.ToInt32(Quantity.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdtName.Text;
                newRow.Cells[2].Value = Quantity.Text;
                newRow.Cells[3].Value = Price.Text;
                newRow.Cells[4].Value = Convert.ToInt32(Price.Text) * Convert.ToInt32(Quantity.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                Grandtotal = Grandtotal + total;
                Amountlbl.Text = "" + Grandtotal;
            }
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            FillCategory();
            AttendantNamelbl.Text = Form1.AttendantName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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
            //cbSearchCategory.ValueMember = "CatName";
            //cbSearchCategory.DataSource = dt;
            Categorybox.ValueMember = "CategoryName";
            Categorybox.DataSource = dt;
            Con.Close();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Shoprite Ghana Limited", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("BillId:" + BillDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("AttendantName:" + BillDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("BillDate:" + BillDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("TotalAmount:" + BillDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Programming 2 IA", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 230));
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            if (PrintPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument.Print();
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Categorybox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select ProductName,Quantity from ProductTbl where Category='" + Categorybox.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Attendantsbtn_Click(object sender, EventArgs e)
        {
            AttendantForm Sell = new AttendantForm();
            Sell.Show();
            this.Hide();
        }

        private void Categoriesbtn_Click(object sender, EventArgs e)
        {
            CategoryForm Cat = new CategoryForm();
            Cat.Show();
            this.Hide();
        }

        private void Productbtn_Click(object sender, EventArgs e)
        {
            ProductForm Prod = new ProductForm();
            Prod.Show();
            this.Hide();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BillID.Text == "")
                {
                    MessageBox.Show("Select the Bill to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from BillTbl where BillId=" + BillID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill deleted successfully");
                    Con.Close();
                    populate();
                    BillID.Text = "";
                    AttendantNamelbl.Text = "";
                    Datelbl.Text = "";
                    Price.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AttendantNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void ProdDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ProdtName.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            Quantity.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void barcodebtn_Click(object sender, EventArgs e)
        {
            Barcode form = new Barcode();
            form.Show();
            this.Hide();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (BillID.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values(" + BillID.Text + ",'" + AttendantNamelbl.Text + "','" + Datelbl.Text + "'," + Amountlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    Con.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
