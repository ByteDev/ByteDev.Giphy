[![Build status](https://ci.appveyor.com/api/projects/status/github/bytedev/ByteDev.Giphy?branch=master&svg=true)](https://ci.appveyor.com/project/bytedev/ByteDev-Giphy/branch/master)
[![NuGet Package](https://img.shields.io/nuget/v/ByteDev.Giphy.svg)](https://www.nuget.org/packages/ByteDev.Giphy)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/ByteDev/ByteDev.Giphy/blob/master/LICENSE)

# ByteDev.Giphy

.NET Standard library SDK to help communicate with the [Giphy API](https://developers.giphy.com/docs/).

Using `GiphyApiClient` currently supports the following API endpoints:
- Search GIFs
- Get random GIF
- Get GIF by ID
- Get set of GIFs by IDs
- Get trending GIFs
- Get translated GIFs

You can also communicate with the Giphy Stickers API endpoints using the `GiphyStickerApiClient` class.  This supports endpoints:

- Search stickers
- Get treanding stickers
- Get translated stickers
- Get random stickers
- Get a list of Giphys hand-curated sticker packs
- Get sticker pack details by ID
- Get the stickers within a sticker pack
- Get the children sticker packs within a sticker pack

## Installation

ByteDev.Giphy has been written as a .NET Standard 2.0 library, so you can consume it from a .NET Core or .NET Framework 4.6.1 (or greater) application.

ByteDev.Giphy is hosted as a package on nuget.org.  To install from the Package Manager Console in Visual Studio run:

`Install-Package ByteDev.Giphy`

Further details can be found on the [nuget page](https://www.nuget.org/packages/ByteDev.Giphy/).

## Release Notes

Releases follow semantic versioning.

Full details of the release notes can be viewed on [GitHub](https://github.com/ByteDev/ByteDev.Giphy/blob/master/docs/RELEASE-NOTES.md).

## Usage

Simple example of making a search request against the Giphy API.  Any problems when calling the client and a `GiphyApiClientException` will be thrown.

```csharp
const string giphyApiKey = "YOUR_API_KEY";

var client = new GiphyApiClient(new HttpClient());

var request = new SearchRequest(giphyApiKey) { Query = "cheeseburgers", Limit = 1 };

var response = await client.SearchAsync(request);

Console.Write(response.Gifs.First().Images.Original.Url);
```

To communicate with the Giphy Stickers API (for retrieving stickers and sticker packs) use the `GiphyStickerApiClient` class.

## Further Information

Full documentation on the Giphy API and how to obtain a Giphy API key can be found at: [https://developers.giphy.com/docs/](https://developers.giphy.com/docs/)
