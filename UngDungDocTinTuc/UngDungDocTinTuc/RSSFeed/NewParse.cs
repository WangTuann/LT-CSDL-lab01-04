using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using UngDungDocTinTuc.Model;

namespace UngDungDocTinTuc.RSSFeed
{
    class NewParse
    {
        public List<Article> ParseXml(string xmlContent)
        {
            var document = new XmlDocument();
            document.LoadXml(xmlContent);

            var articles = new List<Article>();
            var itemNodes = document.SelectNodes("//item");
            foreach (XmlNode node in itemNodes)
            {
                var news = new Article()
                {
                    Title = node.SelectSingleNode("title").InnerText,
                    Description = StripHtml(node.SelectSingleNode("description").InnerText),
                    Link = node.SelectSingleNode("link").InnerText,
                    PubblishedDate = ParseDate(node.SelectSingleNode("pubDate").InnerText)
                };

                articles.Add(news);
            }
            return articles;
        }

        private string StripHtml(string content)
        {
            return Regex.Replace(content, "<.*?>", String.Empty).Trim();
        }

        private DateTime ParseDate(string datestr)
        {
            try
            {
                return DateTime.Parse(datestr);
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }
    }
}
