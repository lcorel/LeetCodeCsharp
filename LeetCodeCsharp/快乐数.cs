/*
* 编写一个算法来判断一个数 n 是不是快乐数。
*「快乐数」定义为：对于一个正整数，每一次将该数替换为它每个位置上的数字的平方和，然后重复这个过程直到这个数变为 1，也可能是 无限循环 但始终变不到 1。
* 如果 可以变为  1，那么这个数就是快乐数。
* 如果 n 是快乐数就返回 True ；不是，则返回 False 。
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCsharp
{
    public class 快乐数
    {

        public bool IsHappy(int n)
        {
            //保存计算结果，如果之前存在过，则说明进入了无限循环
            var calcResultList = new List<int>();
            //不等于1，继续计算
            while (true)
            {
                //数字拆分
                var nStr = n.ToString();
                //计算平方和
                var calcResult = nStr.Select((t, i) => Convert.ToInt32(nStr.Substring(i, 1))).Sum(temp => temp * temp);
                //如果之前存在过，则说明进入了无限循环
                if (calcResultList.Contains(calcResult))
                {
                    return false;
                }

                //将计算结果存起来
                calcResultList.Add(calcResult);

                //等于1了，就不再计算了
                if (calcResult.Equals(1))
                {
                    return true;
                }
                //给n赋值，继续计算
                n = calcResult;
            }
        }
    }
}