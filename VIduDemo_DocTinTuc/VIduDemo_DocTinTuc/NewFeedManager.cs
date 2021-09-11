using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIduDemo_DocTinTuc.IO;
using VIduDemo_DocTinTuc.Model;

namespace VIduDemo_DocTinTuc
{
    public class NewFeedManager
    {
        private readonly INewRepository _newRepository;
        private List<Publisher> _publishers;

        public NewFeedManager(INewRepository newRepository)
        {
            _newRepository = newRepository;
        }

        public List<Publisher> GetNewFeed()
        {
            if (_publishers == null)
            {
                _publishers = _newRepository.GetNew();
            }
            return _publishers;
        }
        public void SaveChange()
        {
            _newRepository.Save(_publishers);
        }

        //    internal object GetNews(string text1, string text2)
        //    {
        //        throw new NotImplementedException();
        //    }

        public void RemovePublish(string pubName)
        {
            _publishers.RemoveAll(x => x.Name == pubName);
            SaveChange();
        }

        internal object AddCategory(string publisherName, string categoryName, string rssLink, bool v)
        {
            throw new NotImplementedException();
        }

        //xoa chuyen muc pub name
        public void RemoveCategory(string pubName, string cateName)
        {
            var pub = _publishers.Find(x => x.Name == pubName);
            if (pub == null)
                return;
            pub.RemoveCate(cateName);
            SaveChange();
        }

        internal void RemoveCate(string text1, string text2)
        {
            throw new NotImplementedException();
        }
        //    public bool AddCategory(string publishName, string categoryName, string link, bool isExists)
        //    {
        //        var pub = _publishers.Find(x => x.Name == publishName);
        //        if (pub == null)
        //        {
        //            pub = new Model.Publisher()
        //            {
        //                Name = publishName
        //            };
        //            _publishers.Add(pub);
        //        }
        //        return pub.AddCategory(categoryName, link, isExists);
        //    }

        //    internal void RemoveCate(string text1, string text2)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
