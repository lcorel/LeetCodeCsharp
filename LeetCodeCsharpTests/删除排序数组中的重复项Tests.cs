using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCsharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp.Tests
{
    [TestClass()]
    public class 删除排序数组中的重复项Tests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            Assert.AreEqual(删除排序数组中的重复项.RemoveDuplicates(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }), 5);
        }
    }
}