using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VIduDemo_DocTinTuc.Model;
using VIduDemo_DocTinTuc.RSSFeed;

namespace VIduDemo_DocTinTuc
{
    public class RssReader
    {
        private readonly NewParse _parser;
        private List<Publisher> _publishers;
        private readonly RssReader _rssReader;

        public RssReader(RssReader rssReader)
        {
            _rssReader = rssReader;
        }

        public List<Article> GetNews(string rssLink)
        {
            var feedData = DownloadFeed(rssLink);
            return _parser.ParseXml(feedData);
        }

        private string DownloadFeed(string rssLink)
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            return client.DownloadString(rssLink);
        }

    }
}
