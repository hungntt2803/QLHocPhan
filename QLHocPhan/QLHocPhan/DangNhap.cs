using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLHocPhan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2I45S6H\SQLEXPRESS;Initial Catalog=QLHocphan;Integrated Security=True");
            try {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select *from ADMIN where Username='" + tk + "'and Password='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta= cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Successfully");
                    QuanLyHocPhan qlhp = new QuanLyHocPhan();
                    this.Hide();
                    qlhp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connection");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đồng ý thoát khỏi chương trình?");
            Application.Exit();
        }
    }
}
