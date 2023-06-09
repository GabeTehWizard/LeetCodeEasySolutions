using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySolutions
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<string, int[]> numeralsDict = new Dictionary<string, int[]>
            {
                { "0", new int[] {0,0} },
                { "I", new int[] {0,1} },
                { "IV", new int[] {0,4} },
                { "V", new int[] {0,5} },
                { "IX", new int[] {0,9} },
                { "X", new int[] {0,10} },
                { "XL", new int[] {0,40} },
                { "L", new int[] {0,50} },
                { "XC", new int[] {0,90} },
                { "C", new int[] {0,100} },
                { "CD", new int[] {0,400} },
                { "D", new int[] {0,500} },
                { "CM", new int[] {0,900} },
                { "M", new int[] {0,1000} },
            };

            int len = s.Length;
            if (len == 1) { numeralsDict[s][0]++; }
            else
            {
                string previous = s[0].ToString();
                for (int i = 1; i < len; i++)
                {
                    string current = s[i].ToString();
                    string check = previous + current;
                    if (numeralsDict.ContainsKey(check))
                    {
                        numeralsDict[check][0]++;
                        previous = "0";
                    }
                    else
                    {
                        numeralsDict[previous][0]++;
                        if (i == len - 1) numeralsDict[current][0]++;
                        else previous = current;
                    }
                }
            }
            return numeralsDict.Sum(x => x.Value[0] * x.Value[1]);
        }
    }
}
