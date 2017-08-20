using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            long sumcheck =0;

            VeryBigSum sobj = new VeryBigSum();
            //long[] arr = new long[5] { 10000002, 100000003, 100000000003, 100000000006, 100000009 };
            long[] arr = new long[5] { 1000000001, 8000000002, 1000000003, 1000000004, 1000000005 };

            foreach (long item in arr)
            {
                sumcheck = sumcheck + item;
            }

            Assert.AreEqual(sumcheck, sobj.aVeryBigSum(arr.Length, arr));
        } 
    }
}
