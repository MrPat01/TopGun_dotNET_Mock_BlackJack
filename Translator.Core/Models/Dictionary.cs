using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int CategoryId { get; set; }
        public short priority { get; set; }
        public short typeId { get; set; }
        public short dictionary_typeId { get; set; }
        public DateTime date { get; set; }
        public string inputer { get; set; }
        public virtual Category Category { get; set; }
    }
}
