using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeCsharp
{
    public static class 移动零
    {
        public static void MoveZeroes(int[] nums)
        {
            
            var stepNumber = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i].Equals(0))
                {
                    stepNumber++;
                }
                else
                {
                    if (stepNumber>0)
                    {
                        nums[i - stepNumber] = nums[i];
                    }
                }
            }

            if (stepNumber <= 0) return;
            {
                for (var i = 0; i < stepNumber; i++)
                {
                    nums[nums.Length - 1 - i] = 0;
                }
            }

        }
    }
}