namespace Shoprite_Ghana_Ltd
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RoleSelectbtn = new System.Windows.Forms.ComboBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhide = new System.Windows.Forms.PictureBox();
            this.btnshow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshow)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Username.Location = new System.Drawing.Point(440, 257);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(193, 20);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(440, 307);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(193, 20);
            this.Password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(509, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(331, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(329, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RoleSelectbtn
            // 
            this.RoleSelectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RoleSelectbtn.ForeColor = System.Drawing.Color.Red;
            this.RoleSelectbtn.FormattingEnabled = true;
            this.RoleSelectbtn.Items.AddRange(new object[] {
            "ADMIN",
            "ATTENDANT"});
            this.RoleSelectbtn.Location = new System.Drawing.Point(459, 210);
            this.RoleSelectbtn.Name = "RoleSelectbtn";
            this.RoleSelectbtn.Size = new System.Drawing.Size(121, 21);
            this.RoleSelectbtn.TabIndex = 6;
            this.RoleSelectbtn.Text = "Select Role";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Loginbtn.ForeColor = System.Drawing.Color.Snow;
            this.Loginbtn.Location = new System.Drawing.Point(440, 359);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clearbtn.ForeColor = System.Drawing.Color.Snow;
            this.Clearbtn.Location = new System.Drawing.Point(536, 359);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 8;
            this.Clearbtn.Text = "CLEAR";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(684, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(313, 408);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnhide
            // 
            this.btnhide.BackColor = System.Drawing.Color.Firebrick;
            this.btnhide.Image = ((System.Drawing.Image)(resources.GetObject("btnhide.Image")));
            this.btnhide.Location = new System.Drawing.Point(604, 307);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(29, 20);
            this.btnhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnhide.TabIndex = 12;
            this.btnhide.TabStop = false;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Firebrick;
            this.btnshow.Image = ((System.Drawing.Image)(resources.GetObject("btnshow.Image")));
            this.btnshow.Location = new System.Drawing.Point(604, 307);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(29, 20);
            this.btnshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnshow.TabIndex = 13;
            this.btnshow.TabStop = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(721, 409);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.RoleSelectbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RoleSelectbtn;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnhide;
        private System.Windows.Forms.PictureBox btnshow;
    }
}

