using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteDev.Giphy.Domain
{
    /// <summary>
    /// Represents a content rating within the Giphy API.
    /// </summary>
    public class Rating
    {
        private static readonly Dictionary<RatingType, string> Mappings = new Dictionary<RatingType, string>
        {
            { RatingType.Restricted, "r" },
            { RatingType.ParentalGuidance13, "pg-13" },
            { RatingType.ParentalGuidance, "pg" },
            { RatingType.General, "g" },
            { RatingType.IllustratedContentOnly, "y" },
        };

        /// <summary>
        /// The rating as an enumeration type.
        /// </summary>
        public RatingType Type { get; }

        /// <summary>
        /// Short code for the rating as used by the API.
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Domain.Rating" /> class.
        /// </summary>
        /// <param name="code">Rating short code.</param>
        /// <exception cref="T:System.InvalidOperationException">Unsupported rating code.</exception>
        public Rating(string code)
        {
            Type = ToType(code);
            Code = code.ToLower();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Domain.Rating" /> class.
        /// </summary>
        /// <param name="type">Rating type.</param>
        /// <exception cref="T:System.InvalidOperationException">Unsupported rating type.</exception>
        public Rating(RatingType type)
        {
            Code = ToCode(type);
            Type = type;
        }

        private static RatingType ToType(string code)
        {
            try
            {
                return Mappings.Single(m => m.Value == code).Key;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException($"Unsupported rating code: '{code}'", ex);
            }
        }

        private static string ToCode(RatingType type)
        {
            try
            {
                return Mappings[type];
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Unsupported rating type: '{type}'.", ex);
            }
        }

        public override string ToString()
        {
            return Code;
        }
    }
}