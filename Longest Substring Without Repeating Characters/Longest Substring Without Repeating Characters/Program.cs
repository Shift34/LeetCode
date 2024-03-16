using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> list = new Dictionary<char, int>();
            int MaxLength = 0;
            int Length = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!list.ContainsKey(s[i]))
                {
                    list.Add(s[i], i);
                    Length++;
                }
                else
                {
                    i = list[s[i]];
                    list = new Dictionary<char, int>();
                    if (Length > MaxLength) MaxLength = Length;
                    Length = 0;
                }
            }
            if (Length > MaxLength) MaxLength = Length;
            return MaxLength;
        }
    }
}
