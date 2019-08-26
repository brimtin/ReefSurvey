using System;
using System.Collections.Generic;
using System.Linq;
using directory;

namespace ReefTest.Parser
{
    public static class HeaderParsing
    {
        public static List<string> Tokenize(string rawHeader)
        {
            var separatedByCommas = rawHeader.Split(',');

            return separatedByCommas.ToList();
        }
    }
}
