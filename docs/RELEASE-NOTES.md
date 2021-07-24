# Release Notes

## 5.0.1 - 24 July 2021

Breaking changes:
- (None)

New features:
- (None)

Bug fixes / internal changes:
- Fix where .NET Framework package consumers caused API URI to not be constructed properly.
- Updated package dependencies.

## 5.0.0 - 22 July 2021

Breaking changes:
- All `GiphyApiClient` public methods now throw `ArgumentNullException` on null requests.
- All `GiphyStickerApiClient` public methods now throw `ArgumentNullException` on null requests.
- Types in namespace `ByteDev.Giphy.Request` now exist in namespace `ByteDev.Giphy.Contract.Request`.
- Types in namespace `ByteDev.Giphy.Response` now exist in namespace `ByteDev.Giphy.Contract.Response`.
- Types in namespace `ByteDev.Giphy.Domain` now exist in namespace `ByteDev.Giphy.Contract`.

New features:
- (None)

Bug fixes / internal changes:
- Fixed serialization bug where `GiphyApiClientException.HttpStatusCode` property not being set.
- Updated package dependencies.

## 4.0.2 - 04 August 2020

Breaking changes:
- (None)

New features:
- (None)

Bug fixes / internal changes:
- Package build fixes

## 4.0.1 - 04 August 2020

Breaking changes:
- (None)

New features:
- (None)

Bug fixes / internal changes:
- Added more missing XML documentation
- Removed ByteDev.Common package dependency
- Added ByteDev.ResourceIdentifier dependency

## 4.0.0 - 24 July 2020

Breaking changes:
- Property GiphyApiClientException.HttpStatusCode is now int

New features:
- (None)

Bug fixes / internal changes:
- Fixed bug where message missing when raising GiphyApiClientException
- Added missing XML documentation
- Package build changes

## 3.1.3 - 09 May 2020

Breaking changes:
- (None)

New features:
- (None)

Bug fixes / internal changes:
- XML documentation now added
