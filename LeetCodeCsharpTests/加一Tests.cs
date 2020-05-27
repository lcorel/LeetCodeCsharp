using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCsharp
{
    [TestClass()]
    public class 加一Tests
    {
        [TestMethod()]
        public void PlusOneTest()
        {
            var b = new 加一();
            var result = b.PlusOne(new[] {6, 1, 4, 5, 3, 9, 0, 1, 9, 5, 1, 8, 6, 7, 0, 5, 5, 4, 3});
        }
    }
}