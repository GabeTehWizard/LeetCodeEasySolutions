using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySolutions
{
    internal class IsPalindromeSolution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            string num = x.ToString();
            int len = num.Length / 2;
            return CompareIntegers(num, len - 1, num.Length - len);
        }

        public bool CompareIntegers(string num, int i, int j)
        {
            if (i < 0) return true;
            return num[i] == num[j] ? CompareIntegers(num, i - 1, j + 1): false;
        }
    }
}
