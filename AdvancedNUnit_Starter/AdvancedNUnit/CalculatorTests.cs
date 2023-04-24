using NUnit.Framework;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
            //Assert.AreEqual(expectedResult, result, "optional failure message");
        }

        [Test]
        public void SomeConstraints()
        {
            var subject = new Calculator { Num1 = 6 };
            Assert.That(subject.DivisibleBy3());
            subject.Num1 = 7;
            Assert.That(subject.DivisibleBy3(), Is.False);
            Assert.That(subject.ToString(), Does.Contain("Calculator"));
        }


        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator { Num1 = 2, Num2  = 4};
            var strResult = subject.ToString();
            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator"));

            Assert.That(strResult, Does.Contain("Calculator"));

            Assert.That(strResult, Does.Not.Contain("Potato"));

            Assert.That(strResult, Is.EqualTo("advancednunit.calculator").IgnoreCase);

            Assert.That(strResult, Is.Not.Empty);
        }

        [Test]
        [Category("happy path")]
        public void TestArrayOfStrings()
        {
            var fruit = new List<string>
            {"apple", "pear", "peach", "floor chicken"};
            Assert.That(fruit, Does.Contain("floor chicken"));
            Assert.That(fruit, Has.Count.EqualTo(4));
            Assert.That(fruit, Has.Exactly(2).StartsWith("pea"));
        }

        [Test]
        [Category("happy path")]
        public void TestRange()
        {
            Assert.That(8, Is.InRange(1,10));
            List<int> nums = new List<int> { 4, 2, 7, 5, 9};
            Assert.That(nums, Is.All.InRange(1, 10));
            Assert.That(nums,Has.Exactly(3).InRange(1, 5));
        }

        //[TestCase(2, 4, 6)]
        //[TestCase(-2, 3, 1)]
        [TestCaseSource("AddCases")]
        public void Add_Always_ReturnsExpectedResults(int x, int y, int expResult)
        {
            var subject = new Calculator { Num1 = x, Num2 = y };
            Assert.That(subject.Add(), Is.EqualTo(expResult));
        }

        private static object[] AddCases =
        {
            new int [] {2, 4, 6},
            new int [] {-2, 3, 1}
        }

















        [Test]
        public void StartWithTest()
        {
            string phrase = "Greetings, Salutations, How do you do!";
            Assert.That(phrase, Does.StartWith("G"));
            Assert.That(phrase, Does.StartWith("Greetings"));

            Assert.That(phrase, Does.Not.StartWith("bye"));
        }

        [Test]
        public void ORTest()
        {
            Assert.That(101, Is.LessThan(10).Or.GreaterThan(120));
            Assert.That(101, Is.LessThan(10).Or.GreaterThanOrEqualTo(101));
        }
    }
    
}