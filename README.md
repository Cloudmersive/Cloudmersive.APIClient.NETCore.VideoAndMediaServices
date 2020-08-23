# Cloudmersive.APIClient.NETCore.VideoAndMediaServices - the C# library for the videoapi

The video APIs help you convert, encode, and transcode videos.

This C# SDK is for the [Cloudmersive Video and Media Services API](https://cloudmersive.com/video-and-media-services-api):

- API version: v1
- SDK version: 2.0.4
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new AudioApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of an audio file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var bitRate = 56;  // int? | Optional; Specify the desired bitrate of the converted audio file in kilobytes per second (kB/s). Value may be between 48 and 1,411. By default, the optimal bitrate will be chosen automatically. (optional) 

            try
            {
                // Convert Audio File to AAC format.
                byte[] result = apiInstance.AudioConvertToAac(inputFile, fileUrl, bitRate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AudioApi.AudioConvertToAac: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AudioApi* | [**AudioConvertToAac**](docs/AudioApi.md#audioconverttoaac) | **POST** /video/convert/to/aac | Convert Audio File to AAC format.
*AudioApi* | [**AudioConvertToM4a**](docs/AudioApi.md#audioconverttom4a) | **POST** /video/convert/to/m4a | Convert Audio File to M4A format.
*AudioApi* | [**AudioConvertToMp3**](docs/AudioApi.md#audioconverttomp3) | **POST** /video/convert/to/mp3 | Convert Audio File to MP3 format.
*AudioApi* | [**AudioConvertToWav**](docs/AudioApi.md#audioconverttowav) | **POST** /video/convert/to/wav | Convert Audio File to WAV format.
*VideoApi* | [**VideoConvertToGif**](docs/VideoApi.md#videoconverttogif) | **POST** /video/convert/to/gif | Convert Video to Animated GIF format.
*VideoApi* | [**VideoConvertToMov**](docs/VideoApi.md#videoconverttomov) | **POST** /video/convert/to/mov | Convert Video to MOV format.
*VideoApi* | [**VideoConvertToMp4**](docs/VideoApi.md#videoconverttomp4) | **POST** /video/convert/to/mp4 | Convert Video to MP4 format.
*VideoApi* | [**VideoConvertToStillFrames**](docs/VideoApi.md#videoconverttostillframes) | **POST** /video/convert/to/still-frames | Convert Video to PNG Still Frames.
*VideoApi* | [**VideoConvertToWebm**](docs/VideoApi.md#videoconverttowebm) | **POST** /video/convert/to/webm | Convert Video to WEBM format.
*VideoApi* | [**VideoCutVideo**](docs/VideoApi.md#videocutvideo) | **POST** /video/cut | Cut a Video to a Shorter Length
*VideoApi* | [**VideoGetInfo**](docs/VideoApi.md#videogetinfo) | **POST** /video/convert/get-info | Get detailed information about a video or audio file
*VideoApi* | [**VideoResizeVideo**](docs/VideoApi.md#videoresizevideo) | **POST** /video/resize/preserveAspectRatio | Resizes a Video Preserving the Original Aspect Ratio.
*VideoApi* | [**VideoResizeVideoSimple**](docs/VideoApi.md#videoresizevideosimple) | **POST** /video/resize/target | Resizes a Video without Preserving Aspect Ratio.
*VideoApi* | [**VideoScanForNsfw**](docs/VideoApi.md#videoscanfornsfw) | **POST** /video/scan/nsfw | Scan a Video for NSFW content.
*VideoApi* | [**VideoSplitVideo**](docs/VideoApi.md#videosplitvideo) | **POST** /video/split | Split a Video into Two Shorter Videos


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.MediaInformation](docs/MediaInformation.md)
 - [Model.NsfwResult](docs/NsfwResult.md)
 - [Model.NsfwScannedFrame](docs/NsfwScannedFrame.md)
 - [Model.SplitVideoResult](docs/SplitVideoResult.md)
 - [Model.StillFrame](docs/StillFrame.md)
 - [Model.StillFramesResult](docs/StillFramesResult.md)
 - [Model.VideoFile](docs/VideoFile.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

