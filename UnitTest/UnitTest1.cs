using NUnit.Framework;
using DoesItHavePermutation;
namespace UnitTest
{
    public class Tests
    {
        private Main _main;

        [SetUp]
        public void Setup()
        {
            _main = new Main();
        }

        [Test]
        public void Case1()
        {
            Assert.IsTrue(_main.CheckIfDoesContainPermutation("baba", "abab"));
        }
        [Test]
        public void Case2()
        {
            Assert.IsFalse(_main.CheckIfDoesContainPermutation("baba", "abc"));
        }
        [Test]
        public void Case3()
        {
            Assert.IsTrue(_main.CheckIfDoesContainPermutation("lds", "loodos"));
        }
    }
}