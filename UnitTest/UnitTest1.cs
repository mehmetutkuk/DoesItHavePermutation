using NUnit.Framework;
using DoesItHavePermutation;
namespace UnitTest
{
    public class Tests
    {
        private TestHelper _testHelper;

        [SetUp]
        public void Setup()
        {
            _testHelper = new TestHelper();
        }

        [Test]
        public void CheckIfDoesContainPermutation_returns_true_on_baba_abab()
        {
            Assert.IsTrue(_testHelper.CheckIfDoesContainPermutation("baba", "abab"));
        }

        [Test]
        public void CheckIfDoesContainPermutation_returns_false_on_baba_abc()
        {
            Assert.IsFalse(_testHelper.CheckIfDoesContainPermutation("baba", "abc"));
        }

        [Test]
        public void CheckIfDoesContainPermutation_returns_true_on_lds_loodos()
        {
            Assert.IsTrue(_testHelper.CheckIfDoesContainPermutation("lds", "loodos"));
        }
    }
}