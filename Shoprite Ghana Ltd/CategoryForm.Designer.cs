namespace Shoprite_Ghana_Ltd
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryId = new System.Windows.Forms.TextBox();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.CategoryDescription = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Productsbtn = new System.Windows.Forms.Button();
            this.sellingbtn = new System.Windows.Forms.Button();
            this.Attendantsbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Adminbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE CATEGORIES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(3, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DESCRIPTION";
            // 
            // CategoryId
            // 
            this.CategoryId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CategoryId.Location = new System.Drawing.Point(97, 105);
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Size = new System.Drawing.Size(115, 20);
            this.CategoryId.TabIndex = 8;
            // 
            // CategoryName
            // 
            this.CategoryName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CategoryName.Location = new System.Drawing.Point(97, 174);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(115, 20);
            this.CategoryName.TabIndex = 9;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CategoryDescription.Location = new System.Drawing.Point(97, 235);
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.Size = new System.Drawing.Size(115, 20);
            this.CategoryDescription.TabIndex = 10;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Addbtn.ForeColor = System.Drawing.Color.Snow;
            this.Addbtn.Location = new System.Drawing.Point(11, 316);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(61, 23);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Firebrick;
            this.Updatebtn.ForeColor = System.Drawing.Color.Snow;
            this.Updatebtn.Location = new System.Drawing.Point(95, 316);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(62, 23);
            this.Updatebtn.TabIndex = 5;
            this.Updatebtn.Text = "UPDATE";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Firebrick;
            this.Deletebtn.ForeColor = System.Drawing.Color.Snow;
            this.Deletebtn.Location = new System.Drawing.Point(174, 316);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(58, 23);
            this.Deletebtn.TabIndex = 13;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(535, 328);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.CategoryDescription);
            this.panel1.Controls.Add(this.CategoryName);
            this.panel1.Controls.Add(this.CategoryId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(127, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 507);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Productsbtn
            // 
            this.Productsbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Productsbtn.ForeColor = System.Drawing.Color.Snow;
            this.Productsbtn.Location = new System.Drawing.Point(25, 232);
            this.Productsbtn.Name = "Productsbtn";
            this.Productsbtn.Size = new System.Drawing.Size(75, 23);
            this.Productsbtn.TabIndex = 9;
            this.Productsbtn.Text = "Products";
            this.Productsbtn.UseVisualStyleBackColor = false;
            this.Productsbtn.Click += new System.EventHandler(this.Productsbtn_Click);
            // 
            // sellingbtn
            // 
            this.sellingbtn.BackColor = System.Drawing.Color.Firebrick;
            this.sellingbtn.ForeColor = System.Drawing.Color.Snow;
            this.sellingbtn.Location = new System.Drawing.Point(25, 306);
            this.sellingbtn.Name = "sellingbtn";
            this.sellingbtn.Size = new System.Drawing.Size(75, 23);
            this.sellingbtn.TabIndex = 8;
            this.sellingbtn.Text = "Selling";
            this.sellingbtn.UseVisualStyleBackColor = false;
            this.sellingbtn.Click += new System.EventHandler(this.sellingbtn_Click);
            // 
            // Attendantsbtn
            // 
            this.Attendantsbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Attendantsbtn.ForeColor = System.Drawing.Color.Snow;
            this.Attendantsbtn.Location = new System.Drawing.Point(25, 163);
            this.Attendantsbtn.Name = "Attendantsbtn";
            this.Attendantsbtn.Size = new System.Drawing.Size(75, 23);
            this.Attendantsbtn.TabIndex = 7;
            this.Attendantsbtn.Text = "Attendants";
            this.Attendantsbtn.UseVisualStyleBackColor = false;
            this.Attendantsbtn.Click += new System.EventHandler(this.Attendantsbtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Logoutbtn.ForeColor = System.Drawing.Color.Snow;
            this.Logoutbtn.Location = new System.Drawing.Point(12, 430);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 34);
            this.Logoutbtn.TabIndex = 20;
            this.Logoutbtn.Text = "LOG OUT";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Adminbtn
            // 
            this.Adminbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Adminbtn.ForeColor = System.Drawing.Color.Snow;
            this.Adminbtn.Location = new System.Drawing.Point(25, 94);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Size = new System.Drawing.Size(75, 23);
            this.Adminbtn.TabIndex = 24;
            this.Adminbtn.Text = "Admin";
            this.Adminbtn.UseVisualStyleBackColor = false;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 506);
            this.Controls.Add(this.Adminbtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Productsbtn);
            this.Controls.Add(this.sellingbtn);
            this.Controls.Add(this.Attendantsbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CategoryId;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.TextBox CategoryDescription;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Productsbtn;
        private System.Windows.Forms.Button sellingbtn;
        private System.Windows.Forms.Button Attendantsbtn;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Adminbtn;
    }
}