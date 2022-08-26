namespace Shoprite_Ghana_Ltd
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.Categorysearch = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Categorybox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Attendantsbtn = new System.Windows.Forms.Button();
            this.Sellingbtn = new System.Windows.Forms.Button();
            this.Categoriesbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.Refreshbtn);
            this.panel1.Controls.Add(this.Categorysearch);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProductDGV);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.Categorybox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.ProductId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(122, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 495);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Refreshbtn.ForeColor = System.Drawing.Color.Snow;
            this.Refreshbtn.Location = new System.Drawing.Point(597, 78);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(61, 23);
            this.Refreshbtn.TabIndex = 18;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = false;
            // 
            // Categorysearch
            // 
            this.Categorysearch.ForeColor = System.Drawing.Color.Firebrick;
            this.Categorysearch.FormattingEnabled = true;
            this.Categorysearch.Location = new System.Drawing.Point(476, 78);
            this.Categorysearch.Name = "Categorysearch";
            this.Categorysearch.Size = new System.Drawing.Size(115, 21);
            this.Categorysearch.TabIndex = 17;
            this.Categorysearch.Text = "Select Category";
            this.Categorysearch.SelectedIndexChanged += new System.EventHandler(this.Categorysearch_SelectedIndexChanged);
            // 
            // Price
            // 
            this.Price.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Price.Location = new System.Drawing.Point(97, 336);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(115, 20);
            this.Price.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(0, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CATEGORY";
            // 
            // ProductDGV
            // 
            this.ProductDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.Location = new System.Drawing.Point(261, 105);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.Size = new System.Drawing.Size(511, 376);
            this.ProductDGV.TabIndex = 14;
            this.ProductDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Firebrick;
            this.Deletebtn.ForeColor = System.Drawing.Color.Snow;
            this.Deletebtn.Location = new System.Drawing.Point(176, 397);
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
            this.Updatebtn.Location = new System.Drawing.Point(97, 397);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(73, 23);
            this.Updatebtn.TabIndex = 5;
            this.Updatebtn.Text = "UPDATE";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Addbtn.ForeColor = System.Drawing.Color.Snow;
            this.Addbtn.Location = new System.Drawing.Point(30, 397);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(61, 23);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // Categorybox
            // 
            this.Categorybox.ForeColor = System.Drawing.Color.Firebrick;
            this.Categorybox.FormattingEnabled = true;
            this.Categorybox.Location = new System.Drawing.Point(97, 289);
            this.Categorybox.Name = "Categorybox";
            this.Categorybox.Size = new System.Drawing.Size(115, 21);
            this.Categorybox.TabIndex = 12;
            this.Categorybox.Text = "Select Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(4, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRICE";
            // 
            // Quantity
            // 
            this.Quantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Quantity.Location = new System.Drawing.Point(97, 235);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(115, 20);
            this.Quantity.TabIndex = 10;
            // 
            // ProductName
            // 
            this.ProductName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProductName.Location = new System.Drawing.Point(97, 174);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(115, 20);
            this.ProductName.TabIndex = 9;
            // 
            // ProductId
            // 
            this.ProductId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProductId.Location = new System.Drawing.Point(97, 105);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(115, 20);
            this.ProductId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(3, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "QUANTITY";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(889, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Attendantsbtn
            // 
            this.Attendantsbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Attendantsbtn.ForeColor = System.Drawing.Color.Snow;
            this.Attendantsbtn.Location = new System.Drawing.Point(21, 141);
            this.Attendantsbtn.Name = "Attendantsbtn";
            this.Attendantsbtn.Size = new System.Drawing.Size(75, 23);
            this.Attendantsbtn.TabIndex = 1;
            this.Attendantsbtn.Text = "Attendants";
            this.Attendantsbtn.UseVisualStyleBackColor = false;
            // 
            // Sellingbtn
            // 
            this.Sellingbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Sellingbtn.ForeColor = System.Drawing.Color.Snow;
            this.Sellingbtn.Location = new System.Drawing.Point(21, 274);
            this.Sellingbtn.Name = "Sellingbtn";
            this.Sellingbtn.Size = new System.Drawing.Size(75, 23);
            this.Sellingbtn.TabIndex = 2;
            this.Sellingbtn.Text = "Selling";
            this.Sellingbtn.UseVisualStyleBackColor = false;
            // 
            // Categoriesbtn
            // 
            this.Categoriesbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Categoriesbtn.ForeColor = System.Drawing.Color.Snow;
            this.Categoriesbtn.Location = new System.Drawing.Point(21, 200);
            this.Categoriesbtn.Name = "Categoriesbtn";
            this.Categoriesbtn.Size = new System.Drawing.Size(75, 23);
            this.Categoriesbtn.TabIndex = 3;
            this.Categoriesbtn.Text = "Categories";
            this.Categoriesbtn.UseVisualStyleBackColor = false;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Logoutbtn.ForeColor = System.Drawing.Color.Snow;
            this.Logoutbtn.Location = new System.Drawing.Point(21, 436);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 34);
            this.Logoutbtn.TabIndex = 20;
            this.Logoutbtn.Text = "LOG OUT";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Categoriesbtn);
            this.Controls.Add(this.Sellingbtn);
            this.Controls.Add(this.Attendantsbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Attendantsbtn;
        private System.Windows.Forms.Button Sellingbtn;
        private System.Windows.Forms.Button Categoriesbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ComboBox Categorybox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.ComboBox Categorysearch;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ProductDGV;
        private System.Windows.Forms.Button Logoutbtn;
    }
}