using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteDev.Giphy.Contract
{
    /// <summary>
    /// Represents a language within the Giphy API.
    /// </summary>
    public class Language
    {
        private static readonly Dictionary<LanguageType, string> Mappings = new Dictionary<LanguageType, string>
        {
            { LanguageType.English, "en" },
            { LanguageType.Spanish, "es" },
            { LanguageType.Portuguese, "pt" },
            { LanguageType.Indonesian, "id" },
            { LanguageType.French, "fr" },
            { LanguageType.Arabic, "ar" },
            { LanguageType.Turkish, "tr" },
            { LanguageType.Thai, "th" },
            { LanguageType.Vietnamese, "vi" },
            { LanguageType.German, "de" },
            { LanguageType.Italian, "it" },
            { LanguageType.Japanese, "ja" },
            { LanguageType.ChineseSimplified, "zh-CN" },
            { LanguageType.ChineseTraditional, "zh-TW" },
            { LanguageType.Russian, "ru" },
            { LanguageType.Korean, "ko" },
            { LanguageType.Polish, "pl" },
            { LanguageType.Dutch, "nl" },
            { LanguageType.Romanian, "ro" },
            { LanguageType.Hungarian, "hu" },
            { LanguageType.Swedish, "sv" },
            { LanguageType.Czech, "cs" },
            { LanguageType.Hindi, "hi" },
            { LanguageType.Bengali, "bn" },
            { LanguageType.Danish, "da" },
            { LanguageType.Farsi, "fa" },
            { LanguageType.Filipino, "tl" },
            { LanguageType.Finnish, "fi" },
            { LanguageType.Hebrew, "iw" },
            { LanguageType.Malay, "ms" },
            { LanguageType.Norwegian, "no" },
            { LanguageType.Ukrainian, "uk" }
        };

        /// <summary>
        /// Default language.
        /// </summary>
        public static LanguageType Default => LanguageType.English;

        /// <summary>
        /// The language as a enumeration type.
        /// </summary>
        public LanguageType Type { get; }

        /// <summary>
        /// ISO639-1 code for the language as used by the API.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Language" /> class.
        /// </summary>
        public Language() : this(Default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Language" /> class.
        /// </summary>
        /// <param name="type">Language type.</param>
        /// <exception cref="T:System.InvalidOperationException">Unsupported language type.</exception>
        public Language(LanguageType type)
        {
            Code = ToIsoCode(type);
            Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Language" /> class.
        /// </summary>
        /// <param name="code">ISO639-1 language code.</param>
        /// <exception cref="T:System.InvalidOperationException">Unsupported language code.</exception>
        public Language(string code)
        {
            Type = ToType(code);
            Code = code;
        }

        public override string ToString()
        {
            return Code;
        }

        private static LanguageType ToType(string code)
        {
            var type = Mappings.FirstOrDefault(m => m.Value == code).Key;

            if(type == 0)
                throw new InvalidOperationException($"Unsupported language code: '{code}'");

            return type;
        }

        private static string ToIsoCode(LanguageType type)
        {
            try
            {
                return Mappings[type];
            }
            catch (KeyNotFoundException ex)
            {
                throw new InvalidOperationException($"Unsupported language type: '{type}'", ex);
            }
        }
    }
}