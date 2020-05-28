using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCsharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp.Tests
{
    [TestClass()]
    public class 字符串解码Tests
    {
        [TestMethod()]
        public void DecodeStringTest()
        {
            Assert.AreEqual(字符串解码.DecodeString("3[a]2[bc]"), "aaabcbc");
        }
    }
}