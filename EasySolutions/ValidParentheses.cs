using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySolutions
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            bool roundOpen = false;
            bool curlyOpen = false;
            bool squareOpen = false;
            

            foreach (char c in s)
            {
                if (c == ')' && !roundOpen) return false;
                else if (c == '}' && !curlyOpen) return false;
                else if (c == ']' && !squareOpen) return false;
                else if (c == ')' && roundOpen) roundOpen = false;
                else if (c == '}' && curlyOpen) curlyOpen = false;
                else if (c == ']' && squareOpen) squareOpen = false;
                else if (c == '(' && !roundOpen) roundOpen = true;
                else if (c == '{' && !curlyOpen) curlyOpen = true;
                else if (c == '[' && !squareOpen) squareOpen = true;
            }
            return roundOpen || curlyOpen || squareOpen;
        }
    }
}
