using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.Common;

namespace Translator.Core.Models
{
    public class TranslateFail : BaseEntity
    {
        public string Text { get; set; }
        public TranslateType typeId { get; set; }
    }
}
