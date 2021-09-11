using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIduDemo_DocTinTuc
{
    public partial class AddFeedForm : Form
    {
        private readonly NewFeedManager _newsManager;

        public AddFeedForm(NewFeedManager newsManager)
        {
            _newsManager = newsManager;
            InitializeComponent();
        }

        public bool HasChanges { get; private set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var publisherName = cbbToaSoan.Text;
            var categoryName = txtChuyenMuc.Text;
            var rssLink = txtRSS.Text;

            if (string.IsNullOrWhiteSpace(publisherName) ||
               string.IsNullOrWhiteSpace(categoryName) ||
               string.IsNullOrWhiteSpace(rssLink))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Lỗi");
                return;
            }
            HasChanges = true;

            var success = _newsManager.AddCategory(publisherName, categoryName, rssLink, false);
            if ((bool)success)
            {
                ClearForm();
                return;
            }

            if (MessageBox.Show("Chuyên mục này đã tồn tại, bạn có muốn cập nhật RSS link không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _newsManager.AddCategory(publisherName, categoryName, rssLink, true);
            }
            ClearForm();
        }

        private void ClearForm()
        {
            cbbToaSoan.Text = "";
            txtChuyenMuc.Text = "";
            txtRSS.Text = "";
        }
    }
    }

