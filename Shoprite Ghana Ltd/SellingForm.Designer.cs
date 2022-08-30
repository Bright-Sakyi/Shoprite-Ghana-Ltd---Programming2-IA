namespace Shoprite_Ghana_Ltd
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Categoriesbtn = new System.Windows.Forms.Button();
            this.Productbtn = new System.Windows.Forms.Button();
            this.Attendantsbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barcodebtn = new System.Windows.Forms.Button();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AttendantNamelbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Amountlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddProductbtn = new System.Windows.Forms.Button();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Printbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Categorybox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.ProdtName = new System.Windows.Forms.TextBox();
            this.BillID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Billidlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Logoutbtn.ForeColor = System.Drawing.Color.Snow;
            this.Logoutbtn.Location = new System.Drawing.Point(16, 436);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 34);
            this.Logoutbtn.TabIndex = 25;
            this.Logoutbtn.Text = "LOG OUT";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Categoriesbtn
            // 
            this.Categoriesbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Categoriesbtn.ForeColor = System.Drawing.Color.Snow;
            this.Categoriesbtn.Location = new System.Drawing.Point(16, 200);
            this.Categoriesbtn.Name = "Categoriesbtn";
            this.Categoriesbtn.Size = new System.Drawing.Size(75, 23);
            this.Categoriesbtn.TabIndex = 24;
            this.Categoriesbtn.Text = "Categories";
            this.Categoriesbtn.UseVisualStyleBackColor = false;
            this.Categoriesbtn.Click += new System.EventHandler(this.Categoriesbtn_Click);
            // 
            // Productbtn
            // 
            this.Productbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Productbtn.ForeColor = System.Drawing.Color.Snow;
            this.Productbtn.Location = new System.Drawing.Point(16, 274);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Size = new System.Drawing.Size(75, 23);
            this.Productbtn.TabIndex = 23;
            this.Productbtn.Text = "Products";
            this.Productbtn.UseVisualStyleBackColor = false;
            this.Productbtn.Click += new System.EventHandler(this.Productbtn_Click);
            // 
            // Attendantsbtn
            // 
            this.Attendantsbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Attendantsbtn.ForeColor = System.Drawing.Color.Snow;
            this.Attendantsbtn.Location = new System.Drawing.Point(16, 141);
            this.Attendantsbtn.Name = "Attendantsbtn";
            this.Attendantsbtn.Size = new System.Drawing.Size(75, 23);
            this.Attendantsbtn.TabIndex = 22;
            this.Attendantsbtn.Text = "Attendants";
            this.Attendantsbtn.UseVisualStyleBackColor = false;
            this.Attendantsbtn.Click += new System.EventHandler(this.Attendantsbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.barcodebtn);
            this.panel1.Controls.Add(this.ProdDGV);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.AttendantNamelbl);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Amountlbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AddProductbtn);
            this.panel1.Controls.Add(this.OrderDGV);
            this.panel1.Controls.Add(this.Refreshbtn);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.BillDGV);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.Printbtn);
            this.panel1.Controls.Add(this.Addbtn);
            this.panel1.Controls.Add(this.Categorybox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.ProdtName);
            this.panel1.Controls.Add(this.BillID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Billidlbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(112, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 502);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // barcodebtn
            // 
            this.barcodebtn.BackColor = System.Drawing.Color.Firebrick;
            this.barcodebtn.ForeColor = System.Drawing.Color.Snow;
            this.barcodebtn.Location = new System.Drawing.Point(277, 473);
            this.barcodebtn.Name = "barcodebtn";
            this.barcodebtn.Size = new System.Drawing.Size(115, 23);
            this.barcodebtn.TabIndex = 28;
            this.barcodebtn.Text = "Generate Barcode";
            this.barcodebtn.UseVisualStyleBackColor = false;
            this.barcodebtn.Click += new System.EventHandler(this.barcodebtn_Click);
            // 
            // ProdDGV
            // 
            this.ProdDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(6, 275);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(240, 192);
            this.ProdDGV.TabIndex = 27;
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(806, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AttendantNamelbl
            // 
            this.AttendantNamelbl.AutoSize = true;
            this.AttendantNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AttendantNamelbl.ForeColor = System.Drawing.Color.Snow;
            this.AttendantNamelbl.Location = new System.Drawing.Point(3, 12);
            this.AttendantNamelbl.Name = "AttendantNamelbl";
            this.AttendantNamelbl.Size = new System.Drawing.Size(112, 13);
            this.AttendantNamelbl.TabIndex = 26;
            this.AttendantNamelbl.Text = "ATTEDANT NAME";
            this.AttendantNamelbl.Click += new System.EventHandler(this.AttendantNamelbl_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Datelbl.ForeColor = System.Drawing.Color.Snow;
            this.Datelbl.Location = new System.Drawing.Point(677, 12);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(40, 13);
            this.Datelbl.TabIndex = 25;
            this.Datelbl.Text = "DATE";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(487, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "SALES LIST";
            // 
            // Amountlbl
            // 
            this.Amountlbl.AutoSize = true;
            this.Amountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Amountlbl.ForeColor = System.Drawing.Color.Snow;
            this.Amountlbl.Location = new System.Drawing.Point(556, 233);
            this.Amountlbl.Name = "Amountlbl";
            this.Amountlbl.Size = new System.Drawing.Size(37, 13);
            this.Amountlbl.TabIndex = 23;
            this.Amountlbl.Text = " GHC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(420, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "AMOUNT GHC";
            // 
            // AddProductbtn
            // 
            this.AddProductbtn.BackColor = System.Drawing.Color.Firebrick;
            this.AddProductbtn.ForeColor = System.Drawing.Color.Snow;
            this.AddProductbtn.Location = new System.Drawing.Point(72, 207);
            this.AddProductbtn.Name = "AddProductbtn";
            this.AddProductbtn.Size = new System.Drawing.Size(113, 23);
            this.AddProductbtn.TabIndex = 21;
            this.AddProductbtn.Text = "ADD PRODUCT";
            this.AddProductbtn.UseVisualStyleBackColor = false;
            this.AddProductbtn.Click += new System.EventHandler(this.AddProductbtn_Click);
            // 
            // OrderDGV
            // 
            this.OrderDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.PName,
            this.PQuantity,
            this.PPrice,
            this.Totalamt});
            this.OrderDGV.Location = new System.Drawing.Point(299, 67);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(531, 163);
            this.OrderDGV.TabIndex = 19;
            this.OrderDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDVG_CellContentClick);
            // 
            // PID
            // 
            this.PID.HeaderText = "ProductId";
            this.PID.Name = "PID";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProductName";
            this.PName.Name = "PName";
            // 
            // PQuantity
            // 
            this.PQuantity.HeaderText = "Quantity";
            this.PQuantity.Name = "PQuantity";
            // 
            // PPrice
            // 
            this.PPrice.HeaderText = "Price";
            this.PPrice.Name = "PPrice";
            // 
            // Totalamt
            // 
            this.Totalamt.HeaderText = "Total";
            this.Totalamt.Name = "Totalamt";
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Refreshbtn.ForeColor = System.Drawing.Color.Snow;
            this.Refreshbtn.Location = new System.Drawing.Point(133, 236);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(85, 23);
            this.Refreshbtn.TabIndex = 18;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = false;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // Price
            // 
            this.Price.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Price.Location = new System.Drawing.Point(103, 176);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(140, 20);
            this.Price.TabIndex = 16;
            // 
            // BillDGV
            // 
            this.BillDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Location = new System.Drawing.Point(299, 301);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDGV.Size = new System.Drawing.Size(531, 166);
            this.BillDGV.TabIndex = 14;
            this.BillDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillDGV_CellContentClick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Firebrick;
            this.Deletebtn.ForeColor = System.Drawing.Color.Snow;
            this.Deletebtn.Location = new System.Drawing.Point(647, 473);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(58, 23);
            this.Deletebtn.TabIndex = 13;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Printbtn
            // 
            this.Printbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Printbtn.ForeColor = System.Drawing.Color.Snow;
            this.Printbtn.Location = new System.Drawing.Point(568, 473);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(73, 23);
            this.Printbtn.TabIndex = 5;
            this.Printbtn.Text = "PRINT";
            this.Printbtn.UseVisualStyleBackColor = false;
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Addbtn.ForeColor = System.Drawing.Color.Snow;
            this.Addbtn.Location = new System.Drawing.Point(501, 473);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(61, 23);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Categorybox
            // 
            this.Categorybox.ForeColor = System.Drawing.Color.Firebrick;
            this.Categorybox.FormattingEnabled = true;
            this.Categorybox.Location = new System.Drawing.Point(12, 238);
            this.Categorybox.Name = "Categorybox";
            this.Categorybox.Size = new System.Drawing.Size(115, 21);
            this.Categorybox.TabIndex = 12;
            this.Categorybox.Text = "Select Category";
            this.Categorybox.SelectionChangeCommitted += new System.EventHandler(this.Categorybox_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRICE";
            // 
            // Quantity
            // 
            this.Quantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Quantity.Location = new System.Drawing.Point(103, 138);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(140, 20);
            this.Quantity.TabIndex = 10;
            // 
            // ProdtName
            // 
            this.ProdtName.BackColor = System.Drawing.SystemColors.Window;
            this.ProdtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProdtName.Location = new System.Drawing.Point(103, 103);
            this.ProdtName.Name = "ProdtName";
            this.ProdtName.Size = new System.Drawing.Size(140, 20);
            this.ProdtName.TabIndex = 20;
            // 
            // BillID
            // 
            this.BillID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BillID.Location = new System.Drawing.Point(103, 67);
            this.BillID.Name = "BillID";
            this.BillID.Size = new System.Drawing.Size(140, 20);
            this.BillID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(6, 152);
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
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NAME";
            // 
            // Billidlbl
            // 
            this.Billidlbl.AutoSize = true;
            this.Billidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Billidlbl.ForeColor = System.Drawing.Color.Snow;
            this.Billidlbl.Location = new System.Drawing.Point(3, 74);
            this.Billidlbl.Name = "Billidlbl";
            this.Billidlbl.Size = new System.Drawing.Size(50, 13);
            this.Billidlbl.TabIndex = 5;
            this.Billidlbl.Text = "BILL ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(361, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES STATUS";
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Document = this.PrintDocument;
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Categoriesbtn);
            this.Controls.Add(this.Productbtn);
            this.Controls.Add(this.Attendantsbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button Categoriesbtn;
        private System.Windows.Forms.Button Productbtn;
        private System.Windows.Forms.Button Attendantsbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Amountlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddProductbtn;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Printbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ComboBox Categorybox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox ProdtName;
        private System.Windows.Forms.TextBox BillID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Billidlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AttendantNamelbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.DataGridView ProdDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalamt;
        private System.Windows.Forms.Button barcodebtn;
    }
}