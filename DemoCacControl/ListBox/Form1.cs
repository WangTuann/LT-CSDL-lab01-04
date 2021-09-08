using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemsselect = lbDanhSach.SelectedItems.Count - 1;
            if (itemsselect==0)
            {
                MessageBox.Show("Vui lòng chọn danh sách sinh viên");
            }
            else
            {


                for (int i = itemsselect; i >= 0; i--)
                {
                    lbDanhSachChon.Items.Add(lbDanhSach.SelectedItems[i]);
                    lbDanhSach.Items.RemoveAt(lbDanhSach.SelectedIndices[i]);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lbDanhSachChon.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbDanhSachChon.Items.RemoveAt(lbDanhSachChon.SelectedIndices[i]);
                i--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
