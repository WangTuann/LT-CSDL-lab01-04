using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIduDemo_DocTinTuc.Model;

namespace VIduDemo_DocTinTuc
{
    public partial class Form1 : Form
    {
        private readonly NewFeedManager _newsManager;

        public Form1(NewFeedManager newsManager)
        {
            _newsManager = newsManager;
            InitializeComponent();
        }

        public Form1()
        {
        }

        //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    pnNews.Controls.Clear();

        //    if (e.Node.Level == 1)
        //    {
        //        var articles = _newsManager.GetNews(e.Node.Parent.Text, e.Node.Text);
        //        foreach (var article in articles)
        //        {
        //            var item = new Component.NewsControl();
        //            item.Size = new Size(519, 101);
        //            item.Dock = DockStyle.Top;
        //            item.SetArticle(article);

        //            pnNews.Controls.Add(item);
        //        }
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFeedOnTreeView(_newsManager.GetNewFeed());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new AddFeedForm(_newsManager);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //_newManager.SaveChange();
                ShowFeedOnTreeView(_newsManager.GetNewFeed());
            }
        }
        
        //xóa mục
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tvPubLish.SelectedNode == null) return;
            if (tvPubLish.SelectedNode.Level == 0)
            {
                _newsManager.RemovePublish(tvPubLish.SelectedNode.Text);
            }
            else
            {
                var publishNode = tvPubLish.SelectedNode.Parent;
                _newsManager.RemoveCate(publishNode.Text, tvPubLish.SelectedNode.Text);
            }
            tvPubLish.SelectedNode.Remove();
        }
        // hiển thị các danh sách lên tree view
        private void ShowFeedOnTreeView(List<Publisher> publisher)
        {
            tvPubLish.Nodes.Clear();
            pnNews.Controls.Clear();

            foreach (var pub in publisher)
            {
                var publisherNode = tvPubLish.Nodes.Add(pub.Name);
                foreach (var cate in pub.Categories)
                {
                    publisherNode.Nodes.Add(cate.Name);
                }
            }
            tvPubLish.ExpandAll();
        }

        private void tvPubLish_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
                MessageBox.Show($"Toà soạn: {e.Node.Text}", "Bạn chọn");
            else
            {
                MessageBox.Show($"Toà soạn: {e.Node.Parent.Text}, chuyên mục: {e.Node.Text}", "Bạn chọn");
            }
        }
    }
}
