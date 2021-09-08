﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIduDemo_DocTinTuc.Model;
using System.IO;

namespace VIduDemo_DocTinTuc.IO
{
    
    public class NewRepository : INewRepository
        
    {
        private const string filePath="Data\\Data.txt";
        List<Publisher> INewRepository.GetNew()
        {
            var publishers = new List<Publisher>();
            Publisher office = null;
            string line;
            try
            {
                using(var stream =new FileStream(filePath,FileMode.Open,FileAccess.Read))
                {
                    using (var reader =new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();

                            if (line==null)
                            {
                                break;
                            }
                            if (line.StartsWith("@"))
                            {
                                office = ParsePublisher(line);
                                publishers.Add(office);
                            }
                            else if (line.StartsWith("@")&&office!=null)
                            {
                                var category = ParseCategory(line);
                                office.Categories.Add(category);
                            }
                        }
                    }
                }    
            }
            catch (Exception)
            {
            }
            return publishers;
        }

        public void Save(List<Publisher> publishers)
        {
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    foreach (var publisher in publishers)
                    {
                        writer.WriteLine("@{0}", publisher.Name);

                        foreach (var category in publisher.Categories)
                        {
                            writer.WriteLine("#{0}^{1}", category.Name, category.RssLink);
                        }
                    }
                }
            }
        }
        private Publisher ParsePublisher(string info)
        {
            return new Publisher()
            {
                Name = info.Substring(1).Trim()
            };

        }
        private Category ParseCategory(string info)
        {
            var parts = info.Substring(1).Split('^');

            return new Category()
            {
                Name = parts[0].Trim(),
                RssLink = parts[1].Trim()
            };
        }
    }
}
