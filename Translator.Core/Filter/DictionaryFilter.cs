using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Core.Filter
{
    public class DictionaryFilter
    {
        public string Field { get; set; }
        public string Operation { get; set; }
        public string Value { get; set; }
        public bool DESC { get; set; }
    }
}
