using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LeetCodeCsharp
{
    public class 加一
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits == null)
            {
                return null;
            }

            for (var i = digits.Length-1; i >=0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] += 1;
                    return digits;
                }
            }

            if (digits[0] != 0) return digits;
            var list = digits.ToList();
            list.Insert(0,1);
            return list.ToArray();

        }
    }
}
