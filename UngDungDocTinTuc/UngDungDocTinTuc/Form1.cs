using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungDocTinTuc.Model;

namespace UngDungDocTinTuc
{
    public partial class Form1 : Form
    {
        private readonly NewFeedManager _newsManager;

        public Form1(NewFeedManager newsManager)
        {
            _newsManager = newsManager;
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    ShowFeedOnTreeView(_newsManager.GetNewFeed());
        //}

        //private void ShowFeedOnTreeView(List<Publisher> publishers)
        //{
        //    tvPubLish.Nodes.Clear();
        //    pnNews.Controls.Clear();

        //    foreach (var pub in publishers)
        //    {
        //        var publisherNode = tvPubLish.Nodes.Add(pub.Name);
        //        foreach (var cate in pub.Categories)
        //        {
        //            publisherNode.Nodes.Add(cate.Name);
        //        }
        //    }
        //    tvPubLish.ExpandAll();
        //}
    }
}

