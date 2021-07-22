using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ByteDev.Giphy.Contract.Request;
using ByteDev.Giphy.Contract.Response;
using ByteDev.Giphy.UriFactories;

namespace ByteDev.Giphy
{
    /// <summary>
    /// Represents a client for the Giphy API.
    /// </summary>
    public class GiphyApiClient : ApiClient, IGiphyApiClient
    {
        private readonly GiphyApiUriFactory _uriFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.GiphyApiClient" /> class.
        /// </summary>
        /// <param name="httpClient">HttpClient to use in all API calls.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="httpClient" /> is null.</exception>
        public GiphyApiClient(HttpClient httpClient) : this(httpClient, new GiphyApiClientSettings())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.GiphyApiClient" /> class.
        /// </summary>
        /// <param name="httpClient">HttpClient to use in all API calls.</param>
        /// <param name="settings">Client settings.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="httpClient" /> is null.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="settings" /> is null.</exception>
        public GiphyApiClient(HttpClient httpClient, GiphyApiClientSettings settings) : base(httpClient)
        {
            _uriFactory = new GiphyApiUriFactory(settings);
        }
        
        /// <summary>
        /// Search library of GIFs for a word or phrase.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<SearchResponse> SearchAsync(SearchRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<SearchResponse>(uri, cancellationToken);
        }

        /// <summary>
        /// Returns a random GIF within the category of a specified tag.
        /// If no tag is specified, the GIF returned will be completely random. 
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<RandomResponse> GetRandomAsync(RandomRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<RandomResponse>(uri, cancellationToken);
        }
        
        /// <summary>
        /// Returns GIF metadata when a user enters a GIF's unique ID.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<ByIdResponse> GetByIdAsync(ByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<ByIdResponse>(uri, cancellationToken);
        }
        
        /// <summary>
        /// Returns metadata of multiple GIFs when a user enters multiple GIF unique ID.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<ByIdsResponse> GetByIdsAsync(ByIdsRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<ByIdsResponse>(uri, cancellationToken);
        }
        
        /// <summary>
        /// Returns a list of the top trending GIFs on the internet, consistently updated throughout each day.
        /// The data returned mirrors the GIFs showcased on the GIPHY homepage. Returns 25 results by default. 
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<TrendingResponse> GetTrendingAsync(TrendingRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<TrendingResponse>(uri, cancellationToken);
        }
        
        /// <summary>
        /// Draws on search, but uses the GIPHY special sauce to handle translating from one vocabulary to another.
        /// In this case, words and phrases to GIFs.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<TranslateResponse> TranslateAsync(TranslateRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<TranslateResponse>(uri, cancellationToken);
        }
    }
}