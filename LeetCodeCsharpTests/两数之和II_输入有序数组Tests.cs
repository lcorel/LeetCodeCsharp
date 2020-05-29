using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCsharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp.Tests
{
    [TestClass()]
    public class 两数之和II_输入有序数组Tests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            Assert.AreEqual(两数之和II_输入有序数组.TwoSum(new[] { -3, 3, 4, 90  }, 0),new[] { 1,2});
        }
    }
}