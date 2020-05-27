/*
 *给定一个整数数组 A，返回其中元素之和可被 K 整除的（连续、非空）子数组的数目。
 */

//示例：
//输入：A = [4,5,0,-2,-3,1], K = 5
//输出：7
//解释：
//有 7 个子数组满足其元素之和可被 K = 5 整除：
//[4, 5, 0, -2, -3, 1], [5], [5, 0], [5, 0, -2, -3], [0], [0, -2, -3], [-2, -3]

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp
{
    public static class 和可被K整除的子数组
    {
        public static int SubarraysDivByK(int[] A, int K)
        {
            if (A.Length<1)
            {
                return 0;
            }

            var dic = new Dictionary<int, int> {{0, 1}};
            var sumTemp = 0;
            var ans = 0;
            foreach (var item in A)
            {
                sumTemp += item;
                var modulus = (sumTemp % K + K) % K;
                if (dic.ContainsKey(modulus))
                {
                    var same =  dic.GetValueOrDefault(modulus,0);
                    ans += same;
                    dic[modulus] = same + 1;
                }
                else
                {
                    dic.Add(modulus,1);
                }
            }
            return ans;
        }
    }
}
