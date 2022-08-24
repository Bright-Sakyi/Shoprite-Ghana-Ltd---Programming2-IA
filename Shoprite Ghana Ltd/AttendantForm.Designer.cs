namespace Shoprite_Ghana_Ltd
{
    partial class AttendantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendantForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SellerPassword = new System.Windows.Forms.TextBox();
            this.SellerPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AttendantsDGV = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.SellerAge = new System.Windows.Forms.TextBox();
            this.SellerName = new System.Windows.Forms.TextBox();
            this.SellerId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Categoriesbtn = new System.Windows.Forms.Button();
            this.Sellingbtn = new System.Windows.Forms.Button();
            this.Productsbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SellerPassword);
            this.panel1.Controls.Add(this.SellerPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.AttendantsDGV);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.SellerAge);
            this.panel1.Controls.Add(this.SellerName);
            this.panel1.Controls.Add(this.SellerId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(119, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 495);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(3, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "PASSWORD";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SellerPassword
            // 
            this.SellerPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SellerPassword.Location = new System.Drawing.Point(97, 282);
            this.SellerPassword.Name = "SellerPassword";
            this.SellerPassword.Size = new System.Drawing.Size(115, 20);
            this.SellerPassword.TabIndex = 17;
            this.SellerPassword.TextChanged += new System.EventHandler(this.SellerPassword_TextChanged);
            // 
            // SellerPhone
            // 
            this.SellerPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SellerPhone.Location = new System.Drawing.Point(97, 241);
            this.SellerPhone.Name = "SellerPhone";
            this.SellerPhone.Size = new System.Drawing.Size(115, 20);
            this.SellerPhone.TabIndex = 16;
            this.SellerPhone.TextChanged += new System.EventHandler(this.SellerPhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(3, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "PHONE ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AttendantsDGV
            // 
            this.AttendantsDGV.BackgroundColor = System.Drawing.Color.White;
            this.AttendantsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendantsDGV.Location = new System.Drawing.Point(249, 84);
            this.AttendantsDGV.Name = "AttendantsDGV";
            this.AttendantsDGV.Size = new System.Drawing.Size(511, 376);
            this.AttendantsDGV.TabIndex = 14;
            this.AttendantsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendantsDGV_CellContentClick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Firebrick;
            this.Deletebtn.ForeColor = System.Drawing.Color.Snow;
            this.Deletebtn.Location = new System.Drawing.Point(154, 367);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(58, 23);
            this.Deletebtn.TabIndex = 13;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Firebrick;
            this.Updatebtn.ForeColor = System.Drawing.Color.Snow;
            this.Updatebtn.Location = new System.Drawing.Point(86, 367);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(62, 23);
            this.Updatebtn.TabIndex = 5;
            this.Updatebtn.Text = "UPDATE";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Addbtn.ForeColor = System.Drawing.Color.Snow;
            this.Addbtn.Location = new System.Drawing.Point(19, 367);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(61, 23);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // SellerAge
            // 
            this.SellerAge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SellerAge.Location = new System.Drawing.Point(97, 196);
            this.SellerAge.Name = "SellerAge";
            this.SellerAge.Size = new System.Drawing.Size(115, 20);
            this.SellerAge.TabIndex = 10;
            this.SellerAge.TextChanged += new System.EventHandler(this.SellerAge_TextChanged);
            // 
            // SellerName
            // 
            this.SellerName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SellerName.Location = new System.Drawing.Point(97, 147);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(115, 20);
            this.SellerName.TabIndex = 9;
            this.SellerName.TextChanged += new System.EventHandler(this.SellerName_TextChanged);
            // 
            // SellerId
            // 
            this.SellerId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SellerId.Location = new System.Drawing.Point(97, 105);
            this.SellerId.Name = "SellerId";
            this.SellerId.Size = new System.Drawing.Size(115, 20);
            this.SellerId.TabIndex = 8;
            this.SellerId.TextChanged += new System.EventHandler(this.SellerId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(3, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "AGE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE ATTENDANTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Categoriesbtn
            // 
            this.Categoriesbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Categoriesbtn.ForeColor = System.Drawing.Color.Snow;
            this.Categoriesbtn.Location = new System.Drawing.Point(24, 218);
            this.Categoriesbtn.Name = "Categoriesbtn";
            this.Categoriesbtn.Size = new System.Drawing.Size(75, 23);
            this.Categoriesbtn.TabIndex = 12;
            this.Categoriesbtn.Text = "Categories";
            this.Categoriesbtn.UseVisualStyleBackColor = false;
            this.Categoriesbtn.Click += new System.EventHandler(this.Categoriesbtn_Click);
            // 
            // Sellingbtn
            // 
            this.Sellingbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Sellingbtn.ForeColor = System.Drawing.Color.Snow;
            this.Sellingbtn.Location = new System.Drawing.Point(24, 292);
            this.Sellingbtn.Name = "Sellingbtn";
            this.Sellingbtn.Size = new System.Drawing.Size(75, 23);
            this.Sellingbtn.TabIndex = 11;
            this.Sellingbtn.Text = "Selling";
            this.Sellingbtn.UseVisualStyleBackColor = false;
            this.Sellingbtn.Click += new System.EventHandler(this.Sellingbtn_Click);
            // 
            // Productsbtn
            // 
            this.Productsbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Productsbtn.ForeColor = System.Drawing.Color.Snow;
            this.Productsbtn.Location = new System.Drawing.Point(24, 149);
            this.Productsbtn.Name = "Productsbtn";
            this.Productsbtn.Size = new System.Drawing.Size(75, 23);
            this.Productsbtn.TabIndex = 10;
            this.Productsbtn.Text = "Products";
            this.Productsbtn.UseVisualStyleBackColor = false;
            this.Productsbtn.Click += new System.EventHandler(this.Productsbtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Logoutbtn.ForeColor = System.Drawing.Color.Snow;
            this.Logoutbtn.Location = new System.Drawing.Point(24, 449);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 34);
            this.Logoutbtn.TabIndex = 19;
            this.Logoutbtn.Text = "LOG OUT";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // AttendantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 540);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Categoriesbtn);
            this.Controls.Add(this.Sellingbtn);
            this.Controls.Add(this.Productsbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendantForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView AttendantsDGV;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox SellerAge;
        private System.Windows.Forms.TextBox SellerName;
        private System.Windows.Forms.TextBox SellerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Categoriesbtn;
        private System.Windows.Forms.Button Sellingbtn;
        private System.Windows.Forms.Button Productsbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SellerPassword;
        private System.Windows.Forms.TextBox SellerPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Logoutbtn;
    }
}