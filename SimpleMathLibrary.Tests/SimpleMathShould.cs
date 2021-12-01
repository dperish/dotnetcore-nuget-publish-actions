using NUnit.Framework;

namespace SimpleMathLibrary.Tests
{
    public class SimpleMathShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTwoNumbers()
        {
            const int a = 1;
            const int b = 2;
            const int expected = 3;

            var actual = SimpleMath.Add(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 0)]
        [TestCase(3, 2, 1)]
        public void SubtractTwoNumbers(int a, int b, int expected)
        {
            var actual = SimpleMath.Subtract(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}