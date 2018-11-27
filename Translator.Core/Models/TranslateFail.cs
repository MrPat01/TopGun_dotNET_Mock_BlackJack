using Translator.Core.Common;

namespace Translator.Core.Models
{
    public class TranslateFail : BaseEntity
    {
        public string Text { get; set; }
        public TranslateType TypeId { get; set; }
    }
}
