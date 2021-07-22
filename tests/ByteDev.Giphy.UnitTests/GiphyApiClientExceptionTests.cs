using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NUnit.Framework;

namespace ByteDev.Giphy.UnitTests
{
    [TestFixture]
    public class GiphyApiClientExceptionTests
    {
        private const string ExMessage = "some message";

        [Test]
        public void WhenNoArgs_ThenSetMessageToDefault()
        {
            var sut = new GiphyApiClientException();

            Assert.That(sut.Message, Is.EqualTo("Error occured in the GiphyApiClient."));
        }

        [Test]
        public void WhenMessageSpecified_ThenSetMessage()
        {
            var sut = new GiphyApiClientException(ExMessage);

            Assert.That(sut.Message, Is.EqualTo(ExMessage));
        }

        [Test]
        public void WhenMessageAndInnerExSpecified_ThenSetMessageAndInnerEx()
        {
            var innerException = new Exception();

            var sut = new GiphyApiClientException(ExMessage, innerException);

            Assert.That(sut.Message, Is.EqualTo(ExMessage));
            Assert.That(sut.InnerException, Is.SameAs(innerException));
        }

        [Test]
        public void WhenSerialized_ThenDeserializeCorrectly()
        {
            const int httpStatusCode = 500;

            var sut = new GiphyApiClientException(ExMessage, httpStatusCode);

            var formatter = new BinaryFormatter();
            
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, sut);

                stream.Seek(0, 0);

                var result = (GiphyApiClientException)formatter.Deserialize(stream);

                Assert.That(result.HttpStatusCode, Is.EqualTo(httpStatusCode));
                Assert.That(result.ToString(), Is.EqualTo(sut.ToString()));
            }
        }
    }
}