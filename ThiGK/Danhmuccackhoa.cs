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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_thongtinkhoa
            // 
            this.lbl_thongtinkhoa.AutoSize = true;
            this.lbl_thongtinkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtinkhoa.Location = new System.Drawing.Point(269, 30);
            this.lbl_thongtinkhoa.Name = "lbl_thongtinkhoa";
            this.lbl_thongtinkhoa.Size = new System.Drawing.Size(237, 38);
            this.lbl_thongtinkhoa.TabIndex = 0;
            this.lbl_thongtinkhoa.Text = "Thông tin Khoa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 312);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Danhmuccackhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_thongtinkhoa);
            this.Name = "Danhmuccackhoa";
            this.Text = "Danhmuccackhoa";
            this.Load += new System.EventHandler(this.Danhmuccackhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lbl_thongtinkhoa;
        private System.Windows.Forms.DataGridView dataGridView1;

        private void Danhmuccackhoa_Load(object sender, EventArgs e)
        {

        }
    }
}
