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
        public int JPLength { get; set; }
        public int VNLength { get; set; }
        public int CategoryId { get; set; }
        public short Priority { get; set; }
        public short TypeId { get; set; }
        public short DictionaryTypeId { get; set; }
        public DateTime Date { get; set; }
        public string Inputer { get; set; }
        public virtual Category Category { get; set; }
    }
}
