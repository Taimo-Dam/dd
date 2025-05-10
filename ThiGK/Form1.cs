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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool kiemTra = false;
            SqlConnection conn = new SqlConnection("Data Source=msi;Initial Catalog=QLSV;Integrated Security=True");
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Taikhoan", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if ((txt_username.Text.Trim() == rdr["Tendangnhap"].ToString().Trim()) && (txt_password.Text.Trim() == rdr["Matkhau"].ToString().Trim()))
                        kiemTra = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                return;
            }
            if (kiemTra == true)
            {
                Form ql = new Quanly();
                ql.Show();
                this.Hide();
            } 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }
    }
}
