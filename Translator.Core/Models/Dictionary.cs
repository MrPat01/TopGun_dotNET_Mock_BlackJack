using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Core.Models
{
    public class Dictionary : BaseEntity
    {
        public string JP { get; set; }
        public string VN { get; set; }
        public int JPLen { get; set; }
        public int VNLen { get; set; }
        public int Category { get; set; }
        public short priority { get; set; }
        public short type { get; set; }
        public short dictionary_type { get; set; }
        public DateTime date { get; set; }
        public string inputer { get; set; }
    }
}
