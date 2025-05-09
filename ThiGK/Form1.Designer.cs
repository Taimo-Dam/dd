namespace ThiGK
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
    this.lbl_dangnhap = new System.Windows.Forms.Label();
    this.lbl_username = new System.Windows.Forms.Label();
    this.lbl_password = new System.Windows.Forms.Label();
    this.txt_username = new System.Windows.Forms.TextBox();
    this.txt_password = new System.Windows.Forms.TextBox();
    this.btn_ok = new System.Windows.Forms.Button();
    this.btn_cancel = new System.Windows.Forms.Button();
    this.panel1 = new System.Windows.Forms.Panel();
    this.pictureBox1 = new System.Windows.Forms.PictureBox();
    this.panel1.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
    this.SuspendLayout();
    // 
    // panel1
    // 
    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    this.panel1.Controls.Add(this.pictureBox1);
    this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
    this.panel1.Location = new System.Drawing.Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(300, 530);
    this.panel1.TabIndex = 0;
    // 
    // pictureBox1
    // 
    this.pictureBox1.Image = global::ThiGK.Properties.Resources.user_icon;  // Add a user icon to resources
    this.pictureBox1.Location = new System.Drawing.Point(95, 135);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new System.Drawing.Size(120, 120);
    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    // 
    // lbl_dangnhap
    // 
    this.lbl_dangnhap.AutoSize = true;
    this.lbl_dangnhap.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lbl_dangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    this.lbl_dangnhap.Location = new System.Drawing.Point(350, 40);
    this.lbl_dangnhap.Name = "lbl_dangnhap";
    this.lbl_dangnhap.Size = new System.Drawing.Size(176, 38);
    this.lbl_dangnhap.TabIndex = 0;
    this.lbl_dangnhap.Text = "Đăng nhập";
    // 
    // lbl_username
    // 
    this.lbl_username.AutoSize = true;
    this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    this.lbl_username.Location = new System.Drawing.Point(320, 130);
    this.lbl_username.Name = "lbl_username";
    this.lbl_username.Size = new System.Drawing.Size(108, 23);
    this.lbl_username.TabIndex = 1;
    this.lbl_username.Text = "Username";
    // 
    // txt_username
    // 
    this.txt_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.txt_username.Location = new System.Drawing.Point(320, 160);
    this.txt_username.Name = "txt_username";
    this.txt_username.Size = new System.Drawing.Size(370, 32);
    this.txt_username.TabIndex = 3;
    this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
    this.txt_username.BackColor = System.Drawing.Color.WhiteSmoke;
    // 
    // lbl_password
    // 
    this.lbl_password.AutoSize = true;
    this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    this.lbl_password.Location = new System.Drawing.Point(320, 230);
    this.lbl_password.Name = "lbl_password";
    this.lbl_password.Size = new System.Drawing.Size(103, 23);
    this.lbl_password.TabIndex = 2;
    this.lbl_password.Text = "Password";
    // 
    // txt_password
    // 
    this.txt_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.txt_password.Location = new System.Drawing.Point(320, 260);
    this.txt_password.Name = "txt_password";
    this.txt_password.Size = new System.Drawing.Size(370, 32);
    this.txt_password.TabIndex = 4;
    this.txt_password.UseSystemPasswordChar = true;
    this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
    this.txt_password.BackColor = System.Drawing.Color.WhiteSmoke;
    this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
    // 
    // btn_ok
    // 
    this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    this.btn_ok.FlatAppearance.BorderSize = 0;
    this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btn_ok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.btn_ok.ForeColor = System.Drawing.Color.White;
    this.btn_ok.Location = new System.Drawing.Point(320, 340);
    this.btn_ok.Name = "btn_ok";
    this.btn_ok.Size = new System.Drawing.Size(160, 45);
    this.btn_ok.TabIndex = 5;
    this.btn_ok.Text = "Đăng nhập";
    this.btn_ok.UseVisualStyleBackColor = false;
    this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
    // 
    // btn_cancel
    // 
    this.btn_cancel.BackColor = System.Drawing.Color.White;
    this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    this.btn_cancel.FlatAppearance.BorderSize = 1;
    this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    this.btn_cancel.Location = new System.Drawing.Point(530, 340);
    this.btn_cancel.Name = "btn_cancel";
    this.btn_cancel.Size = new System.Drawing.Size(160, 45);
    this.btn_cancel.TabIndex = 6;
    this.btn_cancel.Text = "Hủy";
    this.btn_cancel.UseVisualStyleBackColor = false;
    this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
    // 
    // Form1
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.White;
    this.ClientSize = new System.Drawing.Size(750, 530);
    this.Controls.Add(this.btn_cancel);
    this.Controls.Add(this.btn_ok);
    this.Controls.Add(this.txt_password);
    this.Controls.Add(this.txt_username);
    this.Controls.Add(this.lbl_password);
    this.Controls.Add(this.lbl_username);
    this.Controls.Add(this.lbl_dangnhap);
    this.Controls.Add(this.panel1);
    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    this.Name = "Form1";
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "Đăng Nhập";
    this.panel1.ResumeLayout(false);
    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
}

        #endregion

        private System.Windows.Forms.Label lbl_dangnhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}

