using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCsharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp.Tests
{
    [TestClass()]
    public class 快乐数Tests
    {
        [TestMethod()]
        public void IsHappyTest()
        {
            var b = new 快乐数();
            var rt = b.IsHappy(19);
        }
    }
}