using StringCalc;


namespace StringCalcTest

{
    public class StringCalcTest
    {

        [Test]
        public void GivenString_ReturnsSomething()
        {

            Assert.That(StringCalcProgram.Add("12"), Is.EqualTo("12"));
        }
        [Test]
        public void GivenEmptyString_ReturnsZero()
        {
            Assert.That(StringCalcProgram.Add(""), Is.EqualTo("0"));
        }
        [Test]
        public void Given1comma2_Returns3()
        {
            Assert.That(StringCalcProgram.Add("1,2"), Is.EqualTo("3"));
        }
        [Test]
        public void GivenNegativeNumber_ReturnException()
        {
            //Assert.That(StringCalcProgram.Add("-1"), Is.EqualTo("3"));
            Assert.That(() => StringCalcProgram.Add("-1"), Throws.TypeOf<ArgumentException>());
        }
        [Test]
        public void GivenNumberBiggerThan1000_ReturnsEmpty()
        {
            Assert.That(StringCalcProgram.Add("1001al12ksajdljP{}{3"), Is.EqualTo("15"));
        }
    }
}