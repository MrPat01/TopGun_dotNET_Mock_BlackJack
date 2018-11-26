using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Core.Common
{
    public class Constants
    {
        public static readonly string FileAppendJp2Vn = "_japanese";
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
