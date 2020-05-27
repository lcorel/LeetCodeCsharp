using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp
{
    [TestClass()]
    public class 两数之和Tests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            var b = new 两数之和();
            var result = 两数之和.TwoSum(new[] {3,3},6);
            //Assert.Fail();
        }
    }
}