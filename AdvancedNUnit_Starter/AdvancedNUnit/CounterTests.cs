using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace AdvancedNUnit
{
    [TestFixture]
    [Ignore("")]
    public class CounterTests
    {
        //private Counter _sut;
        private Counter _sut = new Counter(6);

        public void CreateSUT()
        {
           _sut = new Counter(6);
        }

       

        [Test]
        public void Increment_IncreaseCountByOne()
        {
            CreateSUT();
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }
        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            CreateSUT();
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }
    }
}
