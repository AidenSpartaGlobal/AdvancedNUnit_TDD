using NUnit.Framework;
using SumSquareDifference;

namespace SumSquareDifferenceTests
{
    public class Tests
    {
        [TestCase(10, 2640)]
        public void MethodReturnsDifferenceOfSums(int number, int expectedResult)
        {
            Assert.That(Program.SumSquareDifference(number), Is.EqualTo(expectedResult));
        }
    }
}
