using System;

namespace Translator.Core.Models
{
    public class Dictionary : BaseEntity
    {
        public string Jp { get; set; }
        public string Vn { get; set; }
        public int JpLength { get; set; }
        public int VnLength { get; set; }
        public int CategoryId { get; set; }
        public short Priority { get; set; }
        public short TypeId { get; set; }
        public short DictionaryTypeId { get; set; }
        public DateTime Date { get; set; }
        public string Inputer { get; set; }
        public virtual Category Category { get; set; }
    }
}
