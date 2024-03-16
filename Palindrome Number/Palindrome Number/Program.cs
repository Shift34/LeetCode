using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string text = x.ToString();
            int y = text.Length - 1;
            for (int i = 0; i < y; i++, y--)
            {
                if (text[i] != text[y])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
