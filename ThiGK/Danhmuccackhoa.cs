using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiGK
{
    public partial class Danhmuccackhoa : Form
    {
        public Danhmuccackhoa()
        {
            InitializeComponent();
            loadKhoa();
        }

        private void loadKhoa()
        {
            string connectionString = "Data Source=msi;Initial Catalog=QLSV;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string queryKhoa = "select MaKhoa, TenKhoa from Khoa";
                SqlDataAdapter adapterKhoa = new SqlDataAdapter(queryKhoa, conn);
                DataTable dataTableKhoa = new DataTable();
                adapterKhoa.Fill(dataTableKhoa);
                dataGridView1.DataSource = dataTableKhoa;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.lbl_thongtinkhoa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_thongtinkhoa
            // 
            this.lbl_thongtinkhoa.AutoSize = true;
            this.lbl_thongtinkhoa.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtinkhoa.ForeColor = System.Drawing.Color.White;
            this.lbl_thongtinkhoa.Location = new System.Drawing.Point(30, 20);
            this.lbl_thongtinkhoa.Name = "lbl_thongtinkhoa";
            this.lbl_thongtinkhoa.Size = new System.Drawing.Size(253, 39);
            this.lbl_thongtinkhoa.TabIndex = 0;
            this.lbl_thongtinkhoa.Text = "Thông tin Khoa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 419);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lbl_thongtinkhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 80);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 520);
            this.panel2.TabIndex = 10;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 437);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 34);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Trở về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Danhmuccackhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Danhmuccackhoa";
            this.Text = "Danhmuccackhoa";
            this.Load += new System.EventHandler(this.Danhmuccackhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);



        }

        private System.Windows.Forms.Label lbl_thongtinkhoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;

        private void Danhmuccackhoa_Load(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form ql = new Quanly();
            ql.Show();
            this.Hide();
        }
    }
}
