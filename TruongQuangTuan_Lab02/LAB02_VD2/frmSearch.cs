using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02_VD2
{
    public partial class frmSearch : Form
    {
        private QuanLyGiaoVien quanLyGV;

        public frmSearch()
        {
            InitializeComponent();
        }

        public frmSearch(QuanLyGiaoVien qlgv) : this()
        {
            quanLyGV = qlgv;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var kieu = KieuTim.TheoHoTen;
            if (rdMa.Checked)
            {
                kieu = KieuTim.TheoMa;
            }
            else if (rdTen.Checked)
            {
                kieu = KieuTim.TheoHoTen;
            }
            else if (rdSDT.Checked)
            {
                kieu = KieuTim.TheoSDT;
            }
            var kq = quanLyGV.Tim(txtSearch.Text, kieu);
            if (kq is null)
            {
                MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var frmTBGiaoVien = new frmTBGiaoVien();
                frmTBGiaoVien.SetText(kq.ToString());
                frmTBGiaoVien.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
