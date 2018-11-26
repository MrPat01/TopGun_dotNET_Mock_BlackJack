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
        public static readonly int refresh_time = (1 * 60 * 1000); // 1 min
    }

    public enum TranslateType
    {
        Vn2Jp,
        Jp2Vn
    }
}
