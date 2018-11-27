using System.Collections.Generic;

namespace Translator.Core.Common
{
    public class Constants
    {
        public static readonly string FileAppendJp2Vn = "_japanese";
        public static readonly int RefreshTime = (1 * 60 * 1000); // 1 min
        public static readonly List<string> Operations = new List<string>()
        {
            "Equal",
            "Contain"
        };
    }

    public enum TranslateType
    {
        Vn2Jp,
        Jp2Vn
    }
}
