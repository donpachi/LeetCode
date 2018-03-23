using System;
using Trapping_Rain_Water;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WaterTrapTesting
{
    [TestClass]
    public class WaterTrapTest
    {
        int[] height;
        int res;
        TwoPointerTrap trapProg;

        [TestInitialize]
        public void TestSetup()
        {
            res = -1;
            trapProg = new TwoPointerTrap();
        }

        [TestMethod]
        public void EmptyArrayReturnsZeroTest()
        {
            height = new int[] { };
            res = trapProg.Trap(height);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void ValidArrayTest()
        {
            height = new int[] { 0, 1, 0, 5, 0, 3, 0 };
            res = trapProg.Trap(height);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void MountainArrayReturnsZeroTest()
        {
            height = new int[] { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 };
            res = trapProg.Trap(height);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void SingleElementReturnsZeroTest()
        {
            height = new int[] { 0 };
            res = trapProg.Trap(height);
            Assert.AreEqual(0, res);
        }

    }
}
