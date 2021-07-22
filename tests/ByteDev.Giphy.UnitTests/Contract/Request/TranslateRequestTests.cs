using System;
using ByteDev.Giphy.Contract.Request;
using NUnit.Framework;

namespace ByteDev.Giphy.UnitTests.Contract.Request
{
    [TestFixture]
    public class TranslateRequestTests
    {
        private const string ApiKey = "ABC123";

        private TranslateRequest _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new TranslateRequest(ApiKey);
        }

        [TestFixture]
        public class Weirdness : TranslateRequestTests
        {
            [Test]
            public void WhenValueLessThanZero_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => _sut.Weirdness = -1);
            }

            [Test]
            public void WhenValueGreaterThanTen_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => _sut.Weirdness = 11);
            }
        }
    }
}