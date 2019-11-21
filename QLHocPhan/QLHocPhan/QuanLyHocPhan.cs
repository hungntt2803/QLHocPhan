using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHocPhan
{
    public partial class QuanLyHocPhan : Form
    {
        public QuanLyHocPhan()
        {
            InitializeComponent();
        }

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
    }
}
