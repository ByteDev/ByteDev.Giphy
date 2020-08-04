using System;
using ByteDev.Giphy.Domain;
using NUnit.Framework;

namespace ByteDev.Giphy.UnitTests.Domain
{
    [TestFixture]
    public class LanguageTests
    {
        [Test]
        public void WhenInvalidTypeParam_ThenThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => new Language((LanguageType)999));
        }

        [TestCase(LanguageType.English, "en")]
        [TestCase(LanguageType.Spanish, "es")]
        [TestCase(LanguageType.Portuguese, "pt")]
        [TestCase(LanguageType.Indonesian, "id")]
        [TestCase(LanguageType.French, "fr")]
        [TestCase(LanguageType.Arabic, "ar")]
        [TestCase(LanguageType.Turkish, "tr")]
        [TestCase(LanguageType.Thai, "th")]
        [TestCase(LanguageType.Vietnamese, "vi")]
        [TestCase(LanguageType.German, "de")]
        [TestCase(LanguageType.Italian, "it")]
        [TestCase(LanguageType.Japanese, "ja")]
        [TestCase(LanguageType.ChineseSimplified, "zh-CN")]
        [TestCase(LanguageType.ChineseTraditional, "zh-TW")]
        [TestCase(LanguageType.Russian, "ru")]
        [TestCase(LanguageType.Korean, "ko")]
        [TestCase(LanguageType.Polish, "pl")]
        [TestCase(LanguageType.Dutch, "nl")]
        [TestCase(LanguageType.Romanian, "ro")]
        [TestCase(LanguageType.Hungarian, "hu")]
        [TestCase(LanguageType.Swedish, "sv")]
        [TestCase(LanguageType.Czech, "cs")]
        [TestCase(LanguageType.Hindi, "hi")]
        [TestCase(LanguageType.Bengali, "bn")]
        [TestCase(LanguageType.Danish, "da")]
        [TestCase(LanguageType.Farsi, "fa")]
        [TestCase(LanguageType.Filipino, "tl")]
        [TestCase(LanguageType.Finnish, "fi")]
        [TestCase(LanguageType.Hebrew, "iw")]
        [TestCase(LanguageType.Malay, "ms")]
        [TestCase(LanguageType.Norwegian, "no")]
        [TestCase(LanguageType.Ukrainian, "uk")]
        public void WhenValidTypeParam_ThenSetProperties(LanguageType type, string code)
        {
            var sut = new Language(type);

            Assert.That(sut.Type, Is.EqualTo(type));
            Assert.That(sut.Code, Is.EqualTo(code));
        }

        [Test]
        public void WhenInvalidCodeParam_ThenThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => new Language("abc"));
        }

        [TestCase(LanguageType.English, "en")]
        [TestCase(LanguageType.Spanish, "es")]
        [TestCase(LanguageType.Portuguese, "pt")]
        [TestCase(LanguageType.Indonesian, "id")]
        [TestCase(LanguageType.French, "fr")]
        [TestCase(LanguageType.Arabic, "ar")]
        [TestCase(LanguageType.Turkish, "tr")]
        [TestCase(LanguageType.Thai, "th")]
        [TestCase(LanguageType.Vietnamese, "vi")]
        [TestCase(LanguageType.German, "de")]
        [TestCase(LanguageType.Italian, "it")]
        [TestCase(LanguageType.Japanese, "ja")]
        [TestCase(LanguageType.ChineseSimplified, "zh-CN")]
        [TestCase(LanguageType.ChineseTraditional, "zh-TW")]
        [TestCase(LanguageType.Russian, "ru")]
        [TestCase(LanguageType.Korean, "ko")]
        [TestCase(LanguageType.Polish, "pl")]
        [TestCase(LanguageType.Dutch, "nl")]
        [TestCase(LanguageType.Romanian, "ro")]
        [TestCase(LanguageType.Hungarian, "hu")]
        [TestCase(LanguageType.Swedish, "sv")]
        [TestCase(LanguageType.Czech, "cs")]
        [TestCase(LanguageType.Hindi, "hi")]
        [TestCase(LanguageType.Bengali, "bn")]
        [TestCase(LanguageType.Danish, "da")]
        [TestCase(LanguageType.Farsi, "fa")]
        [TestCase(LanguageType.Filipino, "tl")]
        [TestCase(LanguageType.Finnish, "fi")]
        [TestCase(LanguageType.Hebrew, "iw")]
        [TestCase(LanguageType.Malay, "ms")]
        [TestCase(LanguageType.Norwegian, "no")]
        [TestCase(LanguageType.Ukrainian, "uk")]
        public void WhenValidCodeParam_ThenSetProperties(LanguageType type, string code)
        {
            var sut = new Language(code);

            Assert.That(sut.Type, Is.EqualTo(type));
            Assert.That(sut.Code, Is.EqualTo(code));
        }
    }
}