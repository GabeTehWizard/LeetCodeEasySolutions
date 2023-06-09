using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySolutions
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) 
            {
                int complement = target - nums[i];
                if (numsDict.ContainsKey(complement))
                    return new int[] { numsDict[complement], i };
                numsDict[nums[i]] = i;
            }
            throw new Exception("No combination possible.");
        }
    }
}

