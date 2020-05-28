//给定一个排序数组，你需要在原地删除重复出现的元素，使得每个元素最多出现两次，返回移除后数组的新长度。
//不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。

//示例 1:
//给定 nums = [1, 1, 1, 2, 2, 3],
//函数应返回新长度 length = 5, 并且原数组的前五个元素被修改为 1, 1, 2, 2, 3 。
//你不需要考虑数组中超出新长度后面的元素。

//示例 2:
//给定 nums = [0, 0, 1, 1, 1, 1, 2, 3, 3],
//函数应返回新长度 length = 7, 并且原数组的前五个元素被修改为 0, 0, 1, 1, 2, 3, 3 。
//你不需要考虑数组中超出新长度后面的元素。

namespace LeetCodeCsharp
{
    public static class 删除排序数组中的重复项II
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var i = 0;
            foreach (var n in nums)
                if (i < 2 || n > nums[i - 2])
                    nums[i++] = n;
            return i;

            //if (nums.Length <= 2)
            //{
            //    return nums.Length;
            //}

            //var temp = new Dictionary<int,int>();
            //if (nums[0]==nums[1])
            //{
            //    temp.Add(nums[0], 2);
            //}
            //else
            //{
            //    temp.Add(nums[0], 1);
            //    temp.Add(nums[1], 1);
            //}
            //var num = 0;
            //for (var i = 2; i < nums.Length; i++)
            //{
            //    if (num > 0)
            //    {
            //        nums[i - num] = nums[i];
            //    }

            //    if (temp.TryGetValue(nums[i],out var numValue))
            //    {
            //        if (numValue<2)
            //        {
            //            temp[nums[i]] = numValue+1;
            //        }
            //        else
            //        {
            //            num++;
            //        }
            //    }
            //    else
            //    {
            //        temp.Add(nums[i], 1);
            //    }
            //}

            //return nums.Length - num;
        }
    }
}
