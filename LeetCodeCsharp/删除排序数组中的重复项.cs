using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp
{
    public static class 删除排序数组中的重复项
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
                return nums.Length;
            var a = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[a] != nums[i])
                {
                    nums[++a] = nums[i];
                }
            }

            return a + 1;
        }
    }
}
