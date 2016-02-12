using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] listpeople = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Queue<int> list = new Queue<int>(listpeople);

            while (list.Count != 1)
            {
                list.Enqueue(list.Dequeue());
                list.Dequeue();
            }
    }
}
