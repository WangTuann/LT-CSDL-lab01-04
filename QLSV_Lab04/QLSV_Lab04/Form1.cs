using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_Lab04;



namespace QLSV_Lab04
{
    public partial class Form1 : Form
    {
        QuanLySinhVien qlsv;
        public Form1()
        {
            InitializeComponent();
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.MaSo);
            item.SubItems.Add(sv.HoTen);
            string gt = (sv.GioiTinh == true ? "Nam" : "Nu");
            item.SubItems.Add(gt);
            item.SubItems.Add(sv.NgaySinh.ToShortDateString());
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.SoDienThoai);
            item.SubItems.Add(sv.Email);
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.Hinh);

            this.lvSinhVien.Items.Add(item);
        }
        private void LoadListView(List<SinhVien>ds)
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView(qlsv.DanhSach);
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mkbMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.txtDiaChi.Text = "";
            this.txtEmail.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
            this.mkbSoDienThoai.Text = "";
            this.cbbLop.Text = "CTK43";

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open File Image";
            dlg.FileName = "Hãy chọn File";
            dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
                            + ".jpg;.jpeg;*.gif;*.bmp;"
                            + ".tif;.tiff;*.png|"
                            + "JPEG files (.jpg;.jpeg)|*.jpg;*.jpeg|"
                            + "GIF files (.gif)|.gif|"
                            + "BMP files (.bmp)|.bmp|"
                            + "TIFF files (.tif;.tiff)|*.tif;*.tiff|"
                            + "PNG files (.png)|.png|"
                            + "All files (.)|*.*";

            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var fileName = dlg.FileName;
                txtHinh.Text = fileName;
                pbHinh.Load(fileName);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private SinhVien GetSinhVienLV(ListViewItem item)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = item.SubItems[0].Text;
            sv.HoTen = item.SubItems[1].Text;
            sv.GioiTinh = false;
            if (item.SubItems[2].Text == "Nam")
            {
                sv.GioiTinh = true;
            }
            sv.NgaySinh = DateTime.Parse(item.SubItems[3].Text);
            sv.Lop = item.SubItems[4].Text;
            sv.SoDienThoai = item.SubItems[5].Text;
            sv.Email = item.SubItems[6].Text;
            sv.DiaChi = item.SubItems[7].Text;
            sv.Hinh = item.SubItems[8].Text;
            return sv;
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            sv.MaSo = this.mkbMSSV.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.GioiTinh = gt;
            sv.Lop = this.cbbLop.Text;
            sv.SoDienThoai = this.mkbSoDienThoai.Text;
            sv.Email = this.txtEmail.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNam.Checked)
            {
                gt = true;
            }
            sv.GioiTinh = gt;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mkbMSSV.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cbbLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView(qlsv.DanhSach);
            }
                

        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void lvSinhVien_MouseClick(object sender, MouseEventArgs e)
        {
            //ToolStripItem item=new (ToolStripItem)sender;
        }
        public int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }


        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;

            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Selected)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView(qlsv.DanhSach);
            //this.btnMacDinh.PerformClick();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlsv.DanhSach.Clear();
            qlsv.DocTuFile();
            LoadListView(qlsv.DanhSach);  
        }
    }
}
