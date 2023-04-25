using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzShould
    {

        [Test]
        public void GienOne_Return_OneString()
        {
            Assert.Pass(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void GivenANumber_Return_ItsString(int input, string expOutput)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expOutput));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void GivenANumberDivisibleByThree_Return_Fizz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void GivenANumberDivisibleByFive_Return_Buzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        public void GivenANumberDivisibleByFifteen_Return_FizzBuzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("FizzBuzz"));
        }
    }
}