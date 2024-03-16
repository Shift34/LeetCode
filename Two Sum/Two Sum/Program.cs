using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int different = target - nums[i];

                if (hash.ContainsKey(different))
                    return new int[] { hash[different], i };
                else
                {
                    if (!hash.ContainsKey(nums[i]))
                        hash.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
