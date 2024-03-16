using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Roman
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string IntToRoman(int num)
        {
            string text = "";
            int[] massiv = new int[13] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
            {
                {0,"I"},
                {1,"IV" },
                {2,"V" },
                {3,"IX" },
                {4,"X" },
                {5,"XL" },
                {6,"L" },
                {7,"XC" },
                {8,"C" },
                {9,"CD" },
                {10,"D" },
                {11,"CM" },
                {12,"M" }
            };
            int n = 12;
            while (num > 0)
            {
                if (massiv[n] <= num)
                {
                    text += keyValuePairs[n];
                    num -= massiv[n];
                }
                else
                {
                    n--;
                }
            }
            return text;
        }
    }
}
