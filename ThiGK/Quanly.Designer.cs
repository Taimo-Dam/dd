namespace ThiGK
{
    partial class Quanly
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
    System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
    this.dataGridView1 = new System.Windows.Forms.DataGridView();
    this.lbl_qlsv = new System.Windows.Forms.Label();
    this.lbl_thongtinsv = new System.Windows.Forms.Label();
    this.btn_thongtintk = new System.Windows.Forms.Button();
    this.btn_danhmuccacmon = new System.Windows.Forms.Button();
    this.btn_danhmuccackhoa = new System.Windows.Forms.Button();
    this.btn_exit = new System.Windows.Forms.Button();
    this.lbl_menu = new System.Windows.Forms.Label();
    this.comboBox1 = new System.Windows.Forms.ComboBox();
    this.panel1 = new System.Windows.Forms.Panel();
    this.panel2 = new System.Windows.Forms.Panel();
    this.panelMenu = new System.Windows.Forms.Panel();
    ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
    this.panel1.SuspendLayout();
    this.panel2.SuspendLayout();
    this.panelMenu.SuspendLayout();
    this.SuspendLayout();
    // 
    // panel1
    // 
    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    this.panel1.Controls.Add(this.lbl_qlsv);
    this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel1.Location = new System.Drawing.Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(1200, 80);
    this.panel1.TabIndex = 9;
    // 
    // panelMenu
    // 
    this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
    this.panelMenu.Controls.Add(this.lbl_menu);
    this.panelMenu.Controls.Add(this.btn_thongtintk);
    this.panelMenu.Controls.Add(this.btn_danhmuccacmon);
    this.panelMenu.Controls.Add(this.btn_danhmuccackhoa);
    this.panelMenu.Controls.Add(this.comboBox1);
    this.panelMenu.Controls.Add(this.btn_exit);
    this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
    this.panelMenu.Location = new System.Drawing.Point(0, 80);
    this.panelMenu.Name = "panelMenu";
    this.panelMenu.Size = new System.Drawing.Size(300, 620);
    this.panelMenu.TabIndex = 10;
    // 
    // panel2
    // 
    this.panel2.BackColor = System.Drawing.Color.White;
    this.panel2.Controls.Add(this.lbl_thongtinsv);
    this.panel2.Controls.Add(this.dataGridView1);
    this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
    this.panel2.Location = new System.Drawing.Point(300, 80);
    this.panel2.Name = "panel2";
    this.panel2.Size = new System.Drawing.Size(900, 620);
    this.panel2.TabIndex = 11;
    // 
    // dataGridView1
    // 
    this.dataGridView1.AllowUserToAddRows = false;
    this.dataGridView1.AllowUserToDeleteRows = false;
    this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    | System.Windows.Forms.AnchorStyles.Left) 
    | System.Windows.Forms.AnchorStyles.Right)));
    this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
    this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
    this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
    this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
    this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
    dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
    dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    dataGridViewCellStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
    dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
    dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
    dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
    this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
    this.dataGridView1.ColumnHeadersHeight = 40;
    this.dataGridView1.EnableHeadersVisualStyles = false;
    this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
    this.dataGridView1.Location = new System.Drawing.Point(30, 80);
    this.dataGridView1.Name = "dataGridView1";
    this.dataGridView1.ReadOnly = true;
    this.dataGridView1.RowHeadersVisible = false;
    this.dataGridView1.RowHeadersWidth = 51;
    this.dataGridView1.RowTemplate.Height = 35;
    this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
    this.dataGridView1.Size = new System.Drawing.Size(840, 510);
    this.dataGridView1.TabIndex = 0;
    this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
    // 
    // lbl_qlsv
    // 
    this.lbl_qlsv.AutoSize = true;
    this.lbl_qlsv.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lbl_qlsv.ForeColor = System.Drawing.Color.White;
    this.lbl_qlsv.Location = new System.Drawing.Point(30, 20);
    this.lbl_qlsv.Name = "lbl_qlsv";
    this.lbl_qlsv.Size = new System.Drawing.Size(268, 38);
    this.lbl_qlsv.TabIndex = 1;
    this.lbl_qlsv.Text = "Quản lý sinh viên";
    // 
    // lbl_thongtinsv
    // 
    this.lbl_thongtinsv.AutoSize = true;
    this.lbl_thongtinsv.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lbl_thongtinsv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
    this.lbl_thongtinsv.Location = new System.Drawing.Point(30, 30);
    this.lbl_thongtinsv.Name = "lbl_thongtinsv";
    this.lbl_thongtinsv.Size = new System.Drawing.Size(214, 29);
    this.lbl_thongtinsv.TabIndex = 2;
    this.lbl_thongtinsv.Text = "Thông tin sinh viên";
    // 
    // lbl_menu
    // 
    this.lbl_menu.AutoSize = true;
    this.lbl_menu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lbl_menu.ForeColor = System.Drawing.Color.White;
    this.lbl_menu.Location = new System.Drawing.Point(30, 30);
    this.lbl_menu.Name = "lbl_menu";
    this.lbl_menu.Size = new System.Drawing.Size(78, 29);
    this.lbl_menu.TabIndex = 7;
    this.lbl_menu.Text = "Menu";
    // 
    // btn_thongtintk
    // 
    this.btn_thongtintk.FlatAppearance.BorderSize = 0;
    this.btn_thongtintk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btn_thongtintk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.btn_thongtintk.ForeColor = System.Drawing.Color.White;
    this.btn_thongtintk.Location = new System.Drawing.Point(0, 100);
    this.btn_thongtintk.Name = "btn_thongtintk";
    this.btn_thongtintk.Size = new System.Drawing.Size(300, 60);
    this.btn_thongtintk.TabIndex = 3;
    this.btn_thongtintk.Text = "Thông tin tài khoản";
    this.btn_thongtintk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    this.btn_thongtintk.UseVisualStyleBackColor = true;
    this.btn_thongtintk.Click += new System.EventHandler(this.btn_thongtintk_Click);
    // 
    // btn_danhmuccacmon
    // 
    this.btn_danhmuccacmon.FlatAppearance.BorderSize = 0;
    this.btn_danhmuccacmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btn_danhmuccacmon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.btn_danhmuccacmon.ForeColor = System.Drawing.Color.White;
    this.btn_danhmuccacmon.Location = new System.Drawing.Point(0, 160);
    this.btn_danhmuccacmon.Name = "btn_danhmuccacmon";
    this.btn_danhmuccacmon.Size = new System.Drawing.Size(300, 60);
    this.btn_danhmuccacmon.TabIndex = 4;
    this.btn_danhmuccacmon.Text = "Danh mục các môn";
    this.btn_danhmuccacmon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    this.btn_danhmuccacmon.UseVisualStyleBackColor = true;
    this.btn_danhmuccacmon.Click += new System.EventHandler(this.btn_danhmuccacmon_Click);
    // 
    // btn_danhmuccackhoa
    // 
    this.btn_danhmuccackhoa.FlatAppearance.BorderSize = 0;
    this.btn_danhmuccackhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btn_danhmuccackhoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.btn_danhmuccackhoa.ForeColor = System.Drawing.Color.White;
    this.btn_danhmuccackhoa.Location = new System.Drawing.Point(0, 220);
    this.btn_danhmuccackhoa.Name = "btn_danhmuccackhoa";
    this.btn_danhmuccackhoa.Size = new System.Drawing.Size(300, 60);
    this.btn_danhmuccackhoa.TabIndex = 5;
    this.btn_danhmuccackhoa.Text = "Danh mục các khoa";
    this.btn_danhmuccackhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    this.btn_danhmuccackhoa.UseVisualStyleBackColor = true;
    this.btn_danhmuccackhoa.Click += new System.EventHandler(this.btn_danhmuccackhoa_Click);
    // 
    // comboBox1
    // 
    this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.comboBox1.FormattingEnabled = true;
    this.comboBox1.Location = new System.Drawing.Point(30, 300);
    this.comboBox1.Name = "comboBox1";
    this.comboBox1.Size = new System.Drawing.Size(240, 29);
    this.comboBox1.TabIndex = 8;
    this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
    // 
    // btn_exit
    // 
    this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
    this.btn_exit.FlatAppearance.BorderSize = 0;
    this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.btn_exit.ForeColor = System.Drawing.Color.White;
    this.btn_exit.Location = new System.Drawing.Point(30, 540);
    this.btn_exit.Name = "btn_exit";
    this.btn_exit.Size = new System.Drawing.Size(240, 50);
    this.btn_exit.TabIndex = 6;
    this.btn_exit.Text = "Thoát";
    this.btn_exit.UseVisualStyleBackColor = false;
    this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
    // 
    // Quanly
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.White;
    this.ClientSize = new System.Drawing.Size(1200, 700);
    this.Controls.Add(this.panel2);
    this.Controls.Add(this.panelMenu);
    this.Controls.Add(this.panel1);
    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    this.Name = "Quanly";
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "Quản lý sinh viên";
    ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.panelMenu.ResumeLayout(false);
    this.panelMenu.PerformLayout();
    this.ResumeLayout(false);
}


        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_qlsv;
        private System.Windows.Forms.Label lbl_thongtinsv;
        private System.Windows.Forms.Button btn_thongtintk;
        private System.Windows.Forms.Button btn_danhmuccacmon;
        private System.Windows.Forms.Button btn_danhmuccackhoa;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}