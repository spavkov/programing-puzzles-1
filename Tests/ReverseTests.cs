using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingExcercises1.Puzzles;

namespace ProgrammingExcercises1.Tests
{
    [TestClass]
    public class ReverseTests
    {
        [TestMethod]
        public void ShouldReturnProperTest()
        {
            Assert.AreEqual(Reverse.Solve("iknowhowtocode"),
                "edocotwohwonki");
        }
    }
}