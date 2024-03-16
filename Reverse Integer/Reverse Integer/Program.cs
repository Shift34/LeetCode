using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.Reverse(-2147483648));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int Reverse(int x)
        {
            string text = "";
            if (x < 0)
            {
                text += "-";
                try
                {
                    x = Math.Abs(x);
                }
                catch
                {
                    return 0;
                }
            }
            int lastnumber = 0;
            while(x != 0)
            {
                lastnumber = x % 10;
                x /= 10;
                text += lastnumber;
            }
            try
            {
                return int.Parse(text);
            }
            catch
            {
                return 0;
            }
        }
    }
}
