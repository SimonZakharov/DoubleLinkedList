using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoubleLinkedList;

namespace DListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DLinkedList<int> list = new DLinkedList<int>();
            list.AddFirst(2);
            list.AddLast(3);
            list.AddFirst(1);
            list.AddLast(4);
            list.AddFirst(0);
            list.Reverse();
            string result = list.ToString();
            Assert.AreEqual(result, "4 3 2 1 0 ");
        }
        [TestMethod]
        public void TestMethod2()
        {
            DLinkedList<string> list = new DLinkedList<string>();
            list.AddLast("interfaces");
            list.AddLast("goddamn");
            list.AddLast("these");
            list.AddLast("with");
            list.AddLast("success");
            list.AddLast("no");
            list.AddLast("had");
            list.AddLast("have");
            list.AddLast("I");
            list.Reverse();
            string result = list.ToString();
            Assert.AreEqual(result, "I have had no success with these goddamn interfaces ");
        }
    }
}
