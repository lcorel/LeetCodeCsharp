using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCsharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp.Tests
{
    [TestClass()]
    public class 移除元素Tests
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            
            Assert.AreEqual(移除元素.RemoveElement(new[] { 3, 2, 2, 3 }, 3), 2);
        }
    }
}