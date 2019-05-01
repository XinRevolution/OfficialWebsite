using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficialWebsite.Models.Constant
{
    public class TransitionType
    {
        public static string VERTICAL { get; } = "transition-vertical";

        public static string HORIZONTAL { get; } = "transition-horizontal";

        public static string EXPAND { get; } = "transition-expand";

        public static string NONE { get; } = "transition-none";
    }
}
