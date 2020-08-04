using System.Threading;
using System.Threading.Tasks;
using ByteDev.Giphy.Request;
using ByteDev.Giphy.Response;

namespace ByteDev.Giphy
{
    /// <summary>
    /// Represents a client for the Giphy API.
    /// </summary>
    public interface IGiphyApiClient
    {
        /// <summary>
        /// Search library of GIFs for a word or phrase.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SearchResponse> SearchAsync(SearchRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a random GIF within the category of a specified tag.
        /// If no tag is specified, the GIF returned will be completely random. 
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RandomResponse> GetRandomAsync(RandomRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns GIF metadata when a user enters a GIF's unique ID.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ByIdResponse> GetByIdAsync(ByIdRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns metadata of multiple GIFs when a user enters multiple GIF unique ID.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ByIdsResponse> GetByIdsAsync(ByIdsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a list of the top trending GIFs on the internet, consistently updated throughout each day.
        /// The data returned mirrors the GIFs showcased on the GIPHY homepage. Returns 25 results by default. 
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TrendingResponse> GetTrendingAsync(TrendingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Draws on search, but uses the GIPHY special sauce to handle translating from one vocabulary to another.
        /// In this case, words and phrases to GIFs.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TranslateResponse> TranslateAsync(TranslateRequest request, CancellationToken cancellationToken = default);
    }
}