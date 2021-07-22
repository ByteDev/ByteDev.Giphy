using System;
using System.Runtime.Serialization;

namespace ByteDev.Giphy
{
    /// <summary>
    /// Represents an exception in the GiphyApiClient.
    /// </summary>
    [Serializable]
    public class GiphyApiClientException : Exception
    {
        /// <summary>
        /// Any HTTP status code returned by the API.
        /// </summary>
        public int HttpStatusCode { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.GiphyApiClientException" /> class.
        /// </summary>
        public GiphyApiClientException() : base("Error occured in the GiphyApiClient.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.GiphyApiClientException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public GiphyApiClientException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.GiphyApiClientException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>       
        public GiphyApiClientException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.GiphyApiClientException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="httpStatusCode">The API HTTP status code.</param>
        public GiphyApiClientException(string message, int httpStatusCode) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.GiphyApiClientException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        protected GiphyApiClientException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            HttpStatusCode = (int)info.GetValue(nameof(HttpStatusCode), typeof(int));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue(nameof(HttpStatusCode), HttpStatusCode, typeof(int));
        }
    }
}