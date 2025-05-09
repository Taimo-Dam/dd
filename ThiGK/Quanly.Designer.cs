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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_qlsv = new System.Windows.Forms.Label();
            this.lbl_thongtinsv = new System.Windows.Forms.Label();
            this.btn_thongtintk = new System.Windows.Forms.Button();
            this.btn_danhmuccacmon = new System.Windows.Forms.Button();
            this.btn_danhmuccackhoa = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_qlsv
            // 
            this.lbl_qlsv.AutoSize = true;
            this.lbl_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlsv.Location = new System.Drawing.Point(423, 29);
            this.lbl_qlsv.Name = "lbl_qlsv";
            this.lbl_qlsv.Size = new System.Drawing.Size(268, 38);
            this.lbl_qlsv.TabIndex = 1;
            this.lbl_qlsv.Text = "Quản lý sinh viên";
            // 
            // lbl_thongtinsv
            // 
            this.lbl_thongtinsv.AutoSize = true;
            this.lbl_thongtinsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtinsv.Location = new System.Drawing.Point(581, 94);
            this.lbl_thongtinsv.Name = "lbl_thongtinsv";
            this.lbl_thongtinsv.Size = new System.Drawing.Size(214, 29);
            this.lbl_thongtinsv.TabIndex = 2;
            this.lbl_thongtinsv.Text = "Thông tin sinh viên";
            // 
            // btn_thongtintk
            // 
            this.btn_thongtintk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtintk.Location = new System.Drawing.Point(47, 190);
            this.btn_thongtintk.Name = "btn_thongtintk";
            this.btn_thongtintk.Size = new System.Drawing.Size(264, 40);
            this.btn_thongtintk.TabIndex = 3;
            this.btn_thongtintk.Text = "Thông tin tài khoản";
            this.btn_thongtintk.UseVisualStyleBackColor = true;
            this.btn_thongtintk.Click += new System.EventHandler(this.btn_thongtintk_Click);
            // 
            // btn_danhmuccacmon
            // 
            this.btn_danhmuccacmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhmuccacmon.Location = new System.Drawing.Point(47, 248);
            this.btn_danhmuccacmon.Name = "btn_danhmuccacmon";
            this.btn_danhmuccacmon.Size = new System.Drawing.Size(264, 40);
            this.btn_danhmuccacmon.TabIndex = 4;
            this.btn_danhmuccacmon.Text = "Danh mục các môn";
            this.btn_danhmuccacmon.UseVisualStyleBackColor = true;
            this.btn_danhmuccacmon.Click += new System.EventHandler(this.btn_danhmuccacmon_Click);
            // 
            // btn_danhmuccackhoa
            // 
            this.btn_danhmuccackhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhmuccackhoa.Location = new System.Drawing.Point(47, 312);
            this.btn_danhmuccackhoa.Name = "btn_danhmuccackhoa";
            this.btn_danhmuccackhoa.Size = new System.Drawing.Size(264, 40);
            this.btn_danhmuccackhoa.TabIndex = 5;
            this.btn_danhmuccackhoa.Text = "Danh mục các khoa";
            this.btn_danhmuccackhoa.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(105, 460);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(129, 35);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(55, 94);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(73, 29);
            this.lbl_menu.TabIndex = 7;
            this.lbl_menu.Text = "Menu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 532);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_danhmuccackhoa);
            this.Controls.Add(this.btn_danhmuccacmon);
            this.Controls.Add(this.btn_thongtintk);
            this.Controls.Add(this.lbl_thongtinsv);
            this.Controls.Add(this.lbl_qlsv);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Quanly";
            this.Text = "Quanly";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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