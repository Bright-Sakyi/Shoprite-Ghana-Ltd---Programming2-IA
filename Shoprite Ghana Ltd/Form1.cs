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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string AttendantName = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Spyro\source\repos\Shoprite Ghana Ltd\Shoprite Ghana Ltd\shopritedb.mdf;Integrated Security=True;");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please Enter the Username and Password");
            }
            else
            {
                if (RoleSelectbtn.SelectedIndex > -1)
                {
                    if (RoleSelectbtn.SelectedItem.ToString() == "ADMIN")
                    {
                        if (Username.Text == "Admin" && Password.Text == "Admin")
                        {
                            ProductForm Prod = new ProductForm();
                            Prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are Admin, Enter the Correct Username and Password");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("You are in the Seller Section");
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AttendantTbl where AttendantName='" + Username.Text + "' and AttendantPassword='" + Password.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            AttendantName = Username.Text;
                            AttendantForm sell = new AttendantForm();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password");
                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select the Role to Login");
                }
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            Password.Text = "";
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '\0')
            {
                btnshow.BringToFront();
                Password.PasswordChar = '*';
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if(Password.PasswordChar=='*')
            {
                btnhide.BringToFront();
                Password.PasswordChar = '\0';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
