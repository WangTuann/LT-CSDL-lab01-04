using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIduDemo_DocTinTuc.Model;

namespace VIduDemo_DocTinTuc.IO
{
    public interface INewRepository
    {
        List<Publisher> GetNew();

        void Save(List<Publisher> publishers);



}
}
