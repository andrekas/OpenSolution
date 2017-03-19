using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Aids
{
    public static class Str
    {
        public static string EmptyIfNull(string s)
        {
            return string.IsNullOrEmpty(s) ? string.Empty : s;
        }
    }
}
