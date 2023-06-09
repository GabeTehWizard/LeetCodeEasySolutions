using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySolutions
{
    public class LongestCommonPrefixC
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (!strs.Any()) return "";
            List<char> prefix = new();

            int len = strs.Min(x => x.Length);
            for (int i = 0; i < len; i++)
            {
                prefix.Add(strs[0][i]);
                foreach (string str in strs)
                {
                    if (!str[i].Equals(prefix[i]))
                    {
                        prefix.RemoveAt(i);
                        return string.Concat(prefix);
                    }
                }
            }
            return string.Concat(prefix);
        }
    }
}
