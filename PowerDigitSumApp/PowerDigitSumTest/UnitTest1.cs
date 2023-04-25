using NUnit.Framework;
using PowerDigitSum;

namespace PowerDigitSumTest
{
    public class Tests
    {
        [TestCase(15, 26)]
        public void PowerSumReturnsExpectedSum(int power, int expectedResult)
        {
            Assert.That(Program.PowerSum(power), Is.EqualTo(expectedResult));
        }
    }
}