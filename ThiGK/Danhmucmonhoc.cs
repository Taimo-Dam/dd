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
    public partial class Danhmucmonhoc : Form
    {
        public Danhmucmonhoc()
        {
            InitializeComponent();
            loadMonHoc();
        }

        private void loadMonHoc()
        {
            string connectionString = "Data Source=msi;Initial Catalog=QLSV;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string queryMonhoc = "select MaMH, TenMH, SoTiet from Monhoc";
                SqlDataAdapter adapterMonhoc = new SqlDataAdapter(queryMonhoc, conn);
                DataTable dataTableMonhoc = new DataTable();
                adapterMonhoc.Fill(dataTableMonhoc);
                dataGridView1.DataSource = dataTableMonhoc;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void danhmucmonhoc_Load(object sender, EventArgs e)
        { 
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form exit = new Quanly();
            exit.Show();
            this.Hide();
        }
    }
}
