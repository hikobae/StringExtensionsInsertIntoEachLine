using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensionsInsertIntoEachLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionsInsertIntoEachLine.Tests
{
    [TestClass()]
    public class StringExtensionsTests
    {
        [TestMethod()]
        public void InsertIntoEachLineTest()
        {
            string newline = Environment.NewLine;

            Assert.AreEqual("1abc", "abc".InsertIntoEachLine(0, "1"));
            Assert.AreEqual("a1bc", "abc".InsertIntoEachLine(1, "1"));
            Assert.AreEqual("abc1", "abc".InsertIntoEachLine(3, "1"));
            Assert.AreEqual("abc 1", "abc".InsertIntoEachLine(4, "1"));
            Assert.AreEqual("abc  1", "abc".InsertIntoEachLine(5, "1"));

            Assert.AreEqual("1abc" + newline + "1", ("abc"+ newline).InsertIntoEachLine(0, "1"));
            Assert.AreEqual("abc 1" + newline + "    1", ("abc" + newline).InsertIntoEachLine(4, "1"));

            Assert.AreEqual("1abc" + newline + "1def", ("abc" + newline + "def").InsertIntoEachLine(0, "1"));
            Assert.AreEqual("abc 1" + newline + "def 1", ("abc" + newline + "def").InsertIntoEachLine(4, "1"));
        }
    }
}