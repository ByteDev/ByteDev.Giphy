using System;
using ByteDev.Giphy.Domain;
using NUnit.Framework;

namespace ByteDev.Giphy.UnitTests.Domain
{
    [TestFixture]
    public class RatingTests
    {
        [Test]
        public void WhenInvalidTypeParam_ThenThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => new Rating((RatingType)999));
        }

        [TestCase(RatingType.Restricted, "r")]
        [TestCase(RatingType.ParentalGuidance13, "pg-13")]
        [TestCase(RatingType.ParentalGuidance, "pg")]
        [TestCase(RatingType.General, "g")]
        [TestCase(RatingType.IllustratedContentOnly, "y")]
        public void WhenValidTypeParam_ThenSetProperties(RatingType type, string code)
        {
            var sut = new Rating(type);

            Assert.That(sut.Type, Is.EqualTo(type));
            Assert.That(sut.Code, Is.EqualTo(code));
        }

        [Test]
        public void WhenInvalidCodeParam_ThenThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => new Rating("not-a-code"));
        }

        [TestCase(RatingType.Restricted, "r")]
        [TestCase(RatingType.ParentalGuidance13, "pg-13")]
        [TestCase(RatingType.ParentalGuidance, "pg")]
        [TestCase(RatingType.General, "g")]
        [TestCase(RatingType.IllustratedContentOnly, "y")]
        public void WhenValidCodeParam_ThenSetProperties(RatingType type, string code)
        {
            var sut = new Rating(code);

            Assert.That(sut.Type, Is.EqualTo(type));
            Assert.That(sut.Code, Is.EqualTo(code));
        }
    }
}