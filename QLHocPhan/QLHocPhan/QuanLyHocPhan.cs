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
    public partial class QuanLyHocPhan : Form
    {
        public QuanLyHocPhan()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2I45S6H\SQLEXPRESS;Initial Catalog=QLHocphan;Integrated Security=True");
        private void SinhVienDangKiHocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVienDangKiHocPhan svdkhp = new SinhVienDangKiHocPhan();
            svdkhp.ShowDialog();
        }



        private void ThongTinSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinSinhVien svdhp = new ChinhSuaThongTinSinhVien();
            svdhp.ShowDialog();
        }

        private void DanhSachHocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachHocPhan dshp = new DanhSachHocPhan();
            dshp.ShowDialog();
        }

        private void ThemMoiHocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemMoiHocPhan tmhp = new ThemMoiHocPhan();
            tmhp.ShowDialog();
        }

        private void QuanLyHocPhan_Load(object sender, EventArgs e)
        {
            conn.Open();//mở kết nối
            string sql = "select * from HOCPHAN ";
            SqlCommand cmd = new SqlCommand(sql, conn);//thực hiện câu lệnh truy vấn này đến sql
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dta = new SqlDataAdapter(cmd);//lưu dữ liệu lấy được vào đây
            DataTable dtb = new DataTable();//tạo 1 kho dữ liệu ảo
            dta.Fill(dtb);//đỗ dữ liệu vào kho
            dataGridView1.DataSource = dtb;//đỗ dữ liệu từ kho vào dataGridView
            conn.Close();

        }
    }
}
