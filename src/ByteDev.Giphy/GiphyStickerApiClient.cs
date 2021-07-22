using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ByteDev.Giphy.Contract.Request.Stickers;
using ByteDev.Giphy.Contract.Response.Stickers;
using ByteDev.Giphy.UriFactories;

namespace ByteDev.Giphy
{
    /// <summary>
    /// Represents a client for the Giphy Sticker API.
    /// </summary>
    public class GiphyStickerApiClient : ApiClient, IGiphyStickerApiClient
    {
        private readonly GiphyStickerApiUriFactory _uriFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.GiphyStickerApiClient" /> class.
        /// </summary>
        /// <param name="httpClient">HttpClient to use in all API calls.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="httpClient" /> is null.</exception>
        public GiphyStickerApiClient(HttpClient httpClient) : this(httpClient, new GiphyApiClientSettings())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.GiphyStickerApiClient" /> class.
        /// </summary>
        /// <param name="httpClient">HttpClient to use in all API calls.</param>
        /// <param name="settings">Client settings.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="httpClient" /> is null.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="settings" /> is null.</exception>
        public GiphyStickerApiClient(HttpClient httpClient, GiphyApiClientSettings settings) : base(httpClient)
        {
            _uriFactory = new GiphyStickerApiUriFactory(settings);
        }
        
        /// <summary>
        /// Replicates the functionality and requirements of the classic GIPHY search,
        /// but returns animated stickers rather than GIFs.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<StickerSearchResponse> SearchStickersAsync(StickerSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<StickerSearchResponse>(uri, cancellationToken);
        }
        
        /// <summary>
        /// Fetch Stickers currently trending online. Hand curated by the GIPHY editorial team.
        /// Returns 25 results by default.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<StickerTrendingResponse> GetTrendingStickersAsync(StickerTrendingRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<StickerTrendingResponse>(uri, cancellationToken);
        }
        
        /// <summary>
        /// The translate API draws on search, but uses the GIPHY special sauce to handle translating
        /// from one vocabulary to another. In this case, words and phrases to GIFs.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<StickerTranslateResponse> TranslateStickersAsync(StickerTranslateRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<StickerTranslateResponse>(uri, cancellationToken);
        }
        
        /// <summary>
        /// Returns a random sticker, limited by tag.
        /// Excluding the tag parameter will return a random Sticker from the GIPHY catalog.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<StickerRandomResponse> GetRandomStickerAsync(StickerRandomRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<StickerRandomResponse>(uri, cancellationToken);
        }

        /// <summary>
        /// Returns a list of all sticker packs available.
        /// List is hand-curated by the GIPHY editorial team.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<StickerPackListResponse> GetStickerPackListAsync(StickerPackListingRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<StickerPackListResponse>(uri, cancellationToken);
        }

        /// <summary>
        /// Returns the metadata for an individual sticker pack.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<StickerPackByIdResponse> GetStickerPackByIdAsync(StickerPackByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<StickerPackByIdResponse>(uri, cancellationToken);
        }

        /// <summary>
        /// Returns the stickers within an individual sticker pack.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<StickerPackStickersResponse> GetStickerPackStickersAsync(StickerPackStickersRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<StickerPackStickersResponse>(uri, cancellationToken);
        }

        /// <summary>
        /// Returns the children sticker packs within an individual sticker pack.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="request" /> is null.</exception>
        /// <exception cref="T:ByteDev.Giphy.GiphyApiClientException">Error occured with request.</exception>
        public async Task<StickerPackChildrenPacksResponse> GetStickPackChildrenPacksAsync(StickerPackChildrenPacksRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = _uriFactory.Create(request);

            return await GetAsync<StickerPackChildrenPacksResponse>(uri, cancellationToken);
        }
    }
}