using System;
using NUnit.Framework;

namespace ByteDev.Giphy.UnitTests
{
    [TestFixture]
    public class GiphyApiClientExceptionTests
    {
        [Test]
        public void WhenNoArgs_ThenSetMessageToDefault()
        {
            var sut = new GiphyApiClientException();

            Assert.That(sut.Message, Is.EqualTo("Error occured in the GiphyApiClient."));
        }

        [Test]
        public void WhenMessageSpecified_ThenSetMessage()
        {
            var sut = new GiphyApiClientException("Some message.");

            Assert.That(sut.Message, Is.EqualTo("Some message."));
        }

        [Test]
        public void WhenMessageAndInnerExSpecified_ThenSetMessageAndInnerEx()
        {
            var innerException = new Exception();

            var sut = new GiphyApiClientException("Some message.", innerException);

            Assert.That(sut.Message, Is.EqualTo("Some message."));
            Assert.That(sut.InnerException, Is.SameAs(innerException));
        }

        [Test]
        public void WhenMessageAndStatusCode_ThenSetMessageAndStatusCode()
        {
            var sut = new GiphyApiClientException("Some message.", 404);

            Assert.That(sut.Message, Is.EqualTo("Some message."));
            Assert.That(sut.HttpStatusCode, Is.EqualTo(404));
        }
    }
}