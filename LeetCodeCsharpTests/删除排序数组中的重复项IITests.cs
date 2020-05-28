using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCsharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp.Tests
{
    [TestClass()]
    public class 删除排序数组中的重复项IITests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            Assert.AreEqual(删除排序数组中的重复项II.RemoveDuplicates(new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }), 7);
        }
    }
}