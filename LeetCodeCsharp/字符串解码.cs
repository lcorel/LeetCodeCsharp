//给定一个经过编码的字符串，返回它解码后的字符串。
//编码规则为: k[encoded_string]，表示其中方括号内部的 encoded_string 正好重复 k 次。注意 k 保证为正整数。
//你可以认为输入字符串总是有效的；输入字符串中没有额外的空格，且输入的方括号总是符合格式要求的。
//此外，你可以认为原始数据不包含数字，所有的数字只表示重复的次数 k ，例如不会出现像 3a 或 2[4] 的输入。
//示例:

//s = "3[a]2[bc]", 返回 "aaabcbc".
//s = "3[a2[c]]", 返回 "accaccacc".
//s = "2[abc]3[cd]ef", 返回 "abcabccdcdcdef".

using System;

namespace LeetCodeCsharp
{
    public static class 字符串解码
    {
        public static string DecodeString(string s)
        {
            // 获取最后一个 左 中括号（最深层级的左中括号 或者 最后一个执行单元内的 最深执行层级）
            var lastLeftIndex = s.LastIndexOf("[");
            // 如果不存在左 中括号 代表 当前字符串不需要进行解码操作
            if (lastLeftIndex == -1) return s;
            // 根据左中括号 找到 对应的右中括号的位置
            var lastRightIndex = s.IndexOf("]", lastLeftIndex);
            // 获取需要进行处理的字符串
            var tempString = s.Substring(lastLeftIndex, lastRightIndex - lastLeftIndex + 1);

            var contactString = ""; // 当前 小单元处理结果的存储
            var times = 0; // 需要重复拼接的次数
            var length = 1; // 定义默认数字的长度
            bool digit; // 进行截取字符串 数字转换结果的存储

            #region 尝试获取括号前的数字

            do
            {
                // 从 左中括号向 左推进 数字字符串的长度位 并进行字符串到数值的转换
                digit = int.TryParse(s.Substring(lastLeftIndex - length, length), out var tempTimes);
                // 转换成功说明 数值 是有效的数字 更新 当前字符串的执行次数
                if (digit)
                {
                    times = tempTimes;
                }

                length++; // 先左侧推进一个 数字字符 长度

                // 如果推进到了字符串的最左侧，停止字符串的左移解析
                if (lastLeftIndex < length)
                {
                    break;
                }

            } while (digit);

            #endregion

            // 按照获取的重复次数进行 结果的拼接
            for (var i = 0; i < times; i++)
            {
                contactString += tempString.TrimStart('[').TrimEnd(']');
            }

            // 将解析的结果 替换到 输入字符串中 完成 当前解析的更新
            s = s.Replace(times + tempString, contactString);
            // 将结果 进行再次检查
            return DecodeString(s);
        }
    }
}