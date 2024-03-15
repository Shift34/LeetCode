using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Palindromic_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "caba";
            Solution solution = new Solution();
            Console.WriteLine(solution.LongestPalindrome(s));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            string text = s[0] != null ? s[0].ToString() : "";
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = i + text.Length; j < s.Length; j++)
                {
                    if (s[j] == s[i])
                    {

                            bool flag = true;
                            int l = i+1;
                            int r = j - 1;
                            while (r >= l)
                            {
                                if(s[r] != s[l])
                                {
                                    flag = false;
                                    break;
                                }
                                l++;
                                r--;
                            }
                            if(flag)
                            {
                                text = s.Substring(i, j-i+1);
                            }
                    }
                }
            }
            return text;
        }
    }
}
