using System.Threading;
using System.Threading.Tasks;
using ByteDev.Giphy.Request.Stickers;
using ByteDev.Giphy.Response.Stickers;

namespace ByteDev.Giphy
{
    /// <summary>
    /// Represents a client for the Giphy Stickers API.
    /// </summary>
    public interface IGiphyStickerApiClient
    {
        /// <summary>
        /// Replicates the functionality and requirements of the classic GIPHY search,
        /// but returns animated stickers rather than GIFs.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StickerSearchResponse> SearchStickersAsync(StickerSearchRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Fetch Stickers currently trending online. Hand curated by the GIPHY editorial team.
        /// Returns 25 results by default.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StickerTrendingResponse> GetTrendingStickersAsync(StickerTrendingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// The translate API draws on search, but uses the GIPHY special sauce to handle translating
        /// from one vocabulary to another. In this case, words and phrases to GIFs.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StickerTranslateResponse> TranslateStickersAsync(StickerTranslateRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a random sticker, limited by tag.
        /// Excluding the tag parameter will return a random Sticker from the GIPHY catalog.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StickerRandomResponse> GetRandomStickerAsync(StickerRandomRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a list of all sticker packs available.
        /// List is hand-curated by the GIPHY editorial team.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StickerPackListResponse> GetStickerPackListAsync(StickerPackListingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the metadata for an individual sticker pack.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StickerPackByIdResponse> GetStickerPackByIdAsync(StickerPackByIdRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the stickers within an individual sticker pack.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StickerPackStickersResponse> GetStickerPackStickersAsync(StickerPackStickersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the children sticker packs within an individual sticker pack.
        /// </summary>
        /// <param name="request">Request object.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StickerPackChildrenPacksResponse> GetStickPackChildrenPacksAsync(StickerPackChildrenPacksRequest request, CancellationToken cancellationToken = default);
    }
}