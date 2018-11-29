using System.Collections.Generic;

namespace Translator.Core.Common
{
    public class Constants
    {
        public static readonly int RefreshTime = 1 * 10 * 1000; // 1 min

        public static readonly Dictionary<EnumType, List<string>> Operations = new Dictionary<EnumType, List<string>>()
        {
            {
                EnumType.String, new List<string>()
                {
                    "",
                    "=",
                    "Contain"
                }
            },
            {
                EnumType.Int, new List<string>()
                {
                    "",
                    "=",
                    ">",
                    "<",
                    ">=",
                    "<=",
                }
            },
            {
                EnumType.Date, new List<string>()
                {
                    "",
                    "=",
                    ">",
                    "<",
                    ">=",
                    "<=",
                }
            },
        };

        public static readonly List<string> AndOr = new List<string>()
        {
            "",
            "AND",
            "OR"
        };
    }

    public enum TranslateType
    {
        Vn2Jp = 2,
        Jp2Vn = 1
    }

    public enum EnumType
    {
        String,
        Int,
        Date
    }
}