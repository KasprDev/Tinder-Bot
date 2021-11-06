using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinderClient
{
    class MessageHelpers
    {
        public static string ParseSpintax(Random rand, String s)
        {
            if (s.Contains('{'))
            {
                int closingBracePosition = s.IndexOf('}');
                int openingBracePosition = closingBracePosition;
                while (!s[openingBracePosition].Equals('{')) openingBracePosition--;
                string spintaxBlock = s.Substring(openingBracePosition, closingBracePosition - openingBracePosition + 1);
                string[] items = spintaxBlock.Substring(1, spintaxBlock.Length - 2).Split('|');
                s = s.Replace(spintaxBlock, items[rand.Next(items.Length)]);
                return ParseSpintax(rand, s);
            }
            else { return s; }
        }
    }
}
