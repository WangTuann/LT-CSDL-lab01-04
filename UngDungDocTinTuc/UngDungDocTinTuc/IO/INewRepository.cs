using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngDungDocTinTuc.Model;

namespace UngDungDocTinTuc.IO

{
    public interface INewRepository
    {
        List<Publisher> GetNew();

        void Save(List<Publisher> publishers);

    }
}
