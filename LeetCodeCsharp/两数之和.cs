using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeCsharp
{
    public class 两数之和
    {
        public static IEnumerable<int> TwoSum(int[] nums, int target)
        {
            var kvs = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (kvs.ContainsKey(complement) && kvs[complement] != i)
                {
                    return new [] { i, kvs[complement] };
                }
                if (!kvs.ContainsKey(nums[i]))
                {
                    kvs.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
