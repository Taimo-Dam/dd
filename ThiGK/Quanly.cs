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
    public partial class Quanly : Form
    {
        
        public Quanly()
        {
            InitializeComponent();
            loadSinhVien();
        }

        private void loadSinhVien()
        {
            string connectionString = "Data Source=msi;Initial Catalog=QLSV;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string querySinhvien = "SELECT MaSo, HoTen, NgaySinh, GioiTinh, MaKhoa, MaMH, Diachi, Dienthoai FROM Sinhvien";
                using (SqlDataAdapter adapterSinhvien = new SqlDataAdapter(querySinhvien, conn))
                {
                    DataTable dataTableSinhvien = new DataTable();
                    adapterSinhvien.Fill(dataTableSinhvien);
                    dataGridView1.DataSource = dataTableSinhvien;

                    comboBox1.DataSource = dataTableSinhvien;
                    comboBox1.DisplayMember = "MaSo";  
                    comboBox1.ValueMember = "MaSo";    
                }
            }
        }

        private void Quanly_load(object sender, EventArgs e)
        {
            loadSinhVien();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form exit = new Form1();
            exit.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            string selectedMaSo = comboBox1.SelectedValue.ToString();
            string connectionString = "Data Source=msi;Initial Catalog=QLSV;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string queryForGrid = "SELECT MaSo, HoTen, NgaySinh, GioiTinh, MaKhoa, MaMH, Diachi, Dienthoai FROM Sinhvien WHERE MaSo = @MaSo";
                using (SqlDataAdapter adapter = new SqlDataAdapter(queryForGrid, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@MaSo", selectedMaSo);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
               
            }
        }


        private void btn_danhmuccacmon_Click(object sender, EventArgs e)
        {
            Form mh = new Danhmucmonhoc();
            mh.Show();
            this.Hide();
        }
        private void btn_thongtintk_Click(object sender, EventArgs e)
        {

        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            loadSinhVien();
        }

        private void btn_danhmuccackhoa_Click(object sender, EventArgs e)
        {
            Form ck = new Danhmuccackhoa();
            ck.Show();
            this.Hide();
        }
    }
}
