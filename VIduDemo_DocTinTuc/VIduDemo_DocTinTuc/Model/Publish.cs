using System.Collections.Generic;

namespace VIduDemo_DocTinTuc.Model
{
    internal class Publish
    {
        public string Name { get; internal set; }
        public IEnumerable<object> Categories { get; internal set; }
    }
}