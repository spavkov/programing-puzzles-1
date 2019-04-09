using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingExcercises1.Puzzles;

namespace ProgrammingExcercises1.Tests
{
    [TestClass]
    public class SumOfDigitsTests
    {
        [TestMethod]
        public void ShouldReturnProperTest1()
        {
            Assert.AreEqual(SumOfDigits.Solve(123), 6);
        }

        [TestMethod]
        public void ShouldReturnProperTest2()
        {
            Assert.AreEqual(SumOfDigits.Solve(1234), 10);
        }

        [TestMethod]
        public void ShouldReturnProperTest3()
        {
            Assert.AreEqual(SumOfDigits.Solve(00000), 0);
        }

        [TestMethod]
        public void ShouldReturnProperTest4()
        {
            Assert.AreEqual(SumOfDigits.Solve(1), 1);
        }

        [TestMethod]
        public void ShouldReturnProperTest5()
        {
            Assert.AreEqual(SumOfDigits.Solve(1111111111), 10);
        }
    }
}