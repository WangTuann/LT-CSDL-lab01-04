using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungDocTinTuc.Model
{
    internal class Publish
    {
        public string Name { get; internal set; }
        public IEnumerable<object> Categories { get; internal set; }
    }
}
