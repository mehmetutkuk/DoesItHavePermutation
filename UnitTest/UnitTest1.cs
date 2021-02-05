using NUnit.Framework;
using DoesItHavePermutation;
namespace UnitTest
{
    public class Tests
    {
        private Permutation _permutation;

        [SetUp]
        public void Setup()
        {
            _permutation = new Permutation();
        }

        [Test]
        public void Case1()
        {
            Assert.IsTrue(_permutation.CheckIfDoesContainPermutation("baba", "abab"));
        }
        [Test]
        public void Case2()
        {
            Assert.IsFalse(_permutation.CheckIfDoesContainPermutation("baba", "abc"));
        }
        [Test]
        public void Case3()
        {
            Assert.IsTrue(_permutation.CheckIfDoesContainPermutation("lds", "loodos"));
        }
    }
}