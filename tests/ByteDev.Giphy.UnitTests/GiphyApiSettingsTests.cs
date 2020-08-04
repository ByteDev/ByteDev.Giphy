using NUnit.Framework;

namespace ByteDev.Giphy.UnitTests
{
    [TestFixture]
    public class GiphyApiSettingsTests
    {
        [TestFixture]
        public class BaseUrl : GiphyApiSettingsTests
        {
            [Test]
            public void WhenUseHttpsIsTrue_ThenReturnUrl()
            {
                var sut = new GiphyApiClientSettings { UseHttps = true };

                Assert.That(sut.BaseUrl, Is.EqualTo("https://api.giphy.com"));
            }

            [Test]
            public void WhenUseHttpsIsFalse_ThenReturnUrl()
            {
                var sut = new GiphyApiClientSettings { UseHttps = false };

                Assert.That(sut.BaseUrl, Is.EqualTo("http://api.giphy.com"));
            }
        }
    }
}