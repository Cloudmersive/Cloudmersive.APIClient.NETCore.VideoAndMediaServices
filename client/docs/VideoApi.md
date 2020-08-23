# Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api.VideoApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VideoConvertToGif**](VideoApi.md#videoconverttogif) | **POST** /video/convert/to/gif | Convert Video to Animated GIF format.
[**VideoConvertToMov**](VideoApi.md#videoconverttomov) | **POST** /video/convert/to/mov | Convert Video to MOV format.
[**VideoConvertToMp4**](VideoApi.md#videoconverttomp4) | **POST** /video/convert/to/mp4 | Convert Video to MP4 format.
[**VideoConvertToStillFrames**](VideoApi.md#videoconverttostillframes) | **POST** /video/convert/to/still-frames | Convert Video to PNG Still Frames.
[**VideoConvertToWebm**](VideoApi.md#videoconverttowebm) | **POST** /video/convert/to/webm | Convert Video to WEBM format.
[**VideoCutVideo**](VideoApi.md#videocutvideo) | **POST** /video/cut | Cut a Video to a Shorter Length
[**VideoGetInfo**](VideoApi.md#videogetinfo) | **POST** /video/convert/get-info | Get detailed information about a video or audio file
[**VideoResizeVideo**](VideoApi.md#videoresizevideo) | **POST** /video/resize/preserveAspectRatio | Resizes a Video Preserving the Original Aspect Ratio.
[**VideoResizeVideoSimple**](VideoApi.md#videoresizevideosimple) | **POST** /video/resize/target | Resizes a Video without Preserving Aspect Ratio.
[**VideoScanForNsfw**](VideoApi.md#videoscanfornsfw) | **POST** /video/scan/nsfw | Scan a Video for NSFW content.
[**VideoSplitVideo**](VideoApi.md#videosplitvideo) | **POST** /video/split | Split a Video into Two Shorter Videos


<a name="videoconverttogif"></a>
# **VideoConvertToGif**
> byte[] VideoConvertToGif (System.IO.Stream inputFile = null, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, bool? preserveAspectRatio = null, int? frameRate = null, DateTime? startTime = null, DateTime? timeSpan = null)

Convert Video to Animated GIF format.

Automatically detect video file format and convert it to animated GIF format. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB. Default height is 250 pixels, while preserving the video's aspect ratio.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoConvertToGifExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to 250 pixels, maximum is 500 pixels. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to 250 pixels, maximum is 500 pixels. (optional) 
            var preserveAspectRatio = true;  // bool? | Optional; If false, the original video's aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to 24 frames per second. (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional; Specify the desired starting time of the GIF video in TimeSpan format. (optional) 
            var timeSpan = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional; Specify the desired length of the GIF video in TimeSpan format. Limit is 30 seconds. Default is 10 seconds. (optional) 

            try
            {
                // Convert Video to Animated GIF format.
                byte[] result = apiInstance.VideoConvertToGif(inputFile, fileUrl, maxWidth, maxHeight, preserveAspectRatio, frameRate, startTime, timeSpan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoConvertToGif: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to 250 pixels, maximum is 500 pixels. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to 250 pixels, maximum is 500 pixels. | [optional] 
 **preserveAspectRatio** | **bool?**| Optional; If false, the original video&#39;s aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to 24 frames per second. | [optional] 
 **startTime** | **DateTime?**| Optional; Specify the desired starting time of the GIF video in TimeSpan format. | [optional] 
 **timeSpan** | **DateTime?**| Optional; Specify the desired length of the GIF video in TimeSpan format. Limit is 30 seconds. Default is 10 seconds. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoconverttomov"></a>
# **VideoConvertToMov**
> byte[] VideoConvertToMov (System.IO.Stream inputFile = null, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, bool? preserveAspectRatio = null, int? frameRate = null, int? quality = null)

Convert Video to MOV format.

Automatically detect video file format and convert it to MOV format. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoConvertToMovExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. (optional) 
            var preserveAspectRatio = true;  // bool? | Optional; If false, the original video's aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to original video frame rate. (optional) 
            var quality = 56;  // int? | Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. (optional) 

            try
            {
                // Convert Video to MOV format.
                byte[] result = apiInstance.VideoConvertToMov(inputFile, fileUrl, maxWidth, maxHeight, preserveAspectRatio, frameRate, quality);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoConvertToMov: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. | [optional] 
 **preserveAspectRatio** | **bool?**| Optional; If false, the original video&#39;s aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to original video frame rate. | [optional] 
 **quality** | **int?**| Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoconverttomp4"></a>
# **VideoConvertToMp4**
> byte[] VideoConvertToMp4 (System.IO.Stream inputFile = null, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, bool? preserveAspectRatio = null, int? frameRate = null, int? quality = null)

Convert Video to MP4 format.

Automatically detect video file format and convert it to MP4 format. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoConvertToMp4Example
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. (optional) 
            var preserveAspectRatio = true;  // bool? | Optional; If false, the original video's aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to original video frame rate. (optional) 
            var quality = 56;  // int? | Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. (optional) 

            try
            {
                // Convert Video to MP4 format.
                byte[] result = apiInstance.VideoConvertToMp4(inputFile, fileUrl, maxWidth, maxHeight, preserveAspectRatio, frameRate, quality);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoConvertToMp4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. | [optional] 
 **preserveAspectRatio** | **bool?**| Optional; If false, the original video&#39;s aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to original video frame rate. | [optional] 
 **quality** | **int?**| Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoconverttostillframes"></a>
# **VideoConvertToStillFrames**
> StillFramesResult VideoConvertToStillFrames (System.IO.Stream inputFile = null, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, decimal? framesPerSecond = null)

Convert Video to PNG Still Frames.

Automatically detect video file format and convert it to an array of still frame PNG images. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoConvertToStillFramesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. (optional) 
            var framesPerSecond = 8.14;  // decimal? | Optional; How many video frames per second to be returned as PNG images. Minimum value is 0.1, maximum is 60. Default is 1 frame per second. Maximum of 2000 total frames. (optional) 

            try
            {
                // Convert Video to PNG Still Frames.
                StillFramesResult result = apiInstance.VideoConvertToStillFrames(inputFile, fileUrl, maxWidth, maxHeight, framesPerSecond);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoConvertToStillFrames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. | [optional] 
 **framesPerSecond** | **decimal?**| Optional; How many video frames per second to be returned as PNG images. Minimum value is 0.1, maximum is 60. Default is 1 frame per second. Maximum of 2000 total frames. | [optional] 

### Return type

[**StillFramesResult**](StillFramesResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoconverttowebm"></a>
# **VideoConvertToWebm**
> byte[] VideoConvertToWebm (System.IO.Stream inputFile = null, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, bool? preserveAspectRatio = null, int? frameRate = null, int? quality = null)

Convert Video to WEBM format.

Automatically detect video file format and convert it to WEBM format. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoConvertToWebmExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. (optional) 
            var preserveAspectRatio = true;  // bool? | Optional; If false, the original video's aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to original video frame rate. (optional) 
            var quality = 56;  // int? | Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. (optional) 

            try
            {
                // Convert Video to WEBM format.
                byte[] result = apiInstance.VideoConvertToWebm(inputFile, fileUrl, maxWidth, maxHeight, preserveAspectRatio, frameRate, quality);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoConvertToWebm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. | [optional] 
 **preserveAspectRatio** | **bool?**| Optional; If false, the original video&#39;s aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to original video frame rate. | [optional] 
 **quality** | **int?**| Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videocutvideo"></a>
# **VideoCutVideo**
> byte[] VideoCutVideo (System.IO.Stream inputFile = null, string fileUrl = null, DateTime? startTime = null, DateTime? timeSpan = null)

Cut a Video to a Shorter Length

Cuts a video to the specified start and end times. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoCutVideoExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional; Specify the desired starting time of the cut video in TimeSpan format. (optional) 
            var timeSpan = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional; Specify the desired length of the cut video in TimeSpan format. Leave blank to include the rest of the video. Maximum time is 4 hours. (optional) 

            try
            {
                // Cut a Video to a Shorter Length
                byte[] result = apiInstance.VideoCutVideo(inputFile, fileUrl, startTime, timeSpan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoCutVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **startTime** | **DateTime?**| Optional; Specify the desired starting time of the cut video in TimeSpan format. | [optional] 
 **timeSpan** | **DateTime?**| Optional; Specify the desired length of the cut video in TimeSpan format. Leave blank to include the rest of the video. Maximum time is 4 hours. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videogetinfo"></a>
# **VideoGetInfo**
> MediaInformation VideoGetInfo (System.IO.Stream inputFile = null, string fileUrl = null)

Get detailed information about a video or audio file

Retrieve detailed information about a video or audio file, including format, dimensions, file size, bit rate, duration and start time. Compatible with many formats, including: AVI, ASF, FLV, GIF, MP4, MPEG/MPG, Matroska/WEBM, MOV, AIFF, ASF, CAF, MP3, MP2, MP1, Ogg, OMG/OMA, and WAV. Uses 1 API call per 10 MB of file size.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoGetInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 

            try
            {
                // Get detailed information about a video or audio file
                MediaInformation result = apiInstance.VideoGetInfo(inputFile, fileUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoGetInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 

### Return type

[**MediaInformation**](MediaInformation.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoresizevideo"></a>
# **VideoResizeVideo**
> byte[] VideoResizeVideo (System.IO.Stream inputFile = null, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, int? frameRate = null, int? quality = null, string extension = null)

Resizes a Video Preserving the Original Aspect Ratio.

Resizes a video, while maintaining the original aspect ratio and encoding. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoResizeVideoExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to original video frame rate. (optional) 
            var quality = 56;  // int? | Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. (optional) 
            var extension = extension_example;  // string | Optional; Specify the file extension of the input video. This is recommended when inputting a file directly, without a file name. If no file name is available and no extension is provided, the extension will be inferred from the file data, which may cause a different extension to be used in the output. (optional) 

            try
            {
                // Resizes a Video Preserving the Original Aspect Ratio.
                byte[] result = apiInstance.VideoResizeVideo(inputFile, fileUrl, maxWidth, maxHeight, frameRate, quality, extension);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoResizeVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to original video frame rate. | [optional] 
 **quality** | **int?**| Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. | [optional] 
 **extension** | **string**| Optional; Specify the file extension of the input video. This is recommended when inputting a file directly, without a file name. If no file name is available and no extension is provided, the extension will be inferred from the file data, which may cause a different extension to be used in the output. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoresizevideosimple"></a>
# **VideoResizeVideoSimple**
> byte[] VideoResizeVideoSimple (System.IO.Stream inputFile = null, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, int? frameRate = null, int? quality = null, string extension = null)

Resizes a Video without Preserving Aspect Ratio.

Resizes a video without maintaining original aspect ratio, allowing fully customizable dimensions. May cause image skewing. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoResizeVideoSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to original video frame rate. (optional) 
            var quality = 56;  // int? | Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. (optional) 
            var extension = extension_example;  // string | Optional; Specify the file extension of the input video. This is recommended when inputting a file directly, without a file name. If no file name is available and no extension is provided, the extension will be inferred from the file data, which may cause a different extension to be used in the output. (optional) 

            try
            {
                // Resizes a Video without Preserving Aspect Ratio.
                byte[] result = apiInstance.VideoResizeVideoSimple(inputFile, fileUrl, maxWidth, maxHeight, frameRate, quality, extension);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoResizeVideoSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to original video frame rate. | [optional] 
 **quality** | **int?**| Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. | [optional] 
 **extension** | **string**| Optional; Specify the file extension of the input video. This is recommended when inputting a file directly, without a file name. If no file name is available and no extension is provided, the extension will be inferred from the file data, which may cause a different extension to be used in the output. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoscanfornsfw"></a>
# **VideoScanForNsfw**
> NsfwResult VideoScanForNsfw (System.IO.Stream inputFile = null, string fileUrl = null, decimal? framesPerSecond = null)

Scan a Video for NSFW content.

Automatically detect video file format and scan it for Not Safe For Work (NSFW)/Porn/Racy content. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per frame scanned.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoScanForNsfwExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being scanned. Use this option for files larger than 2GB. (optional) 
            var framesPerSecond = 8.14;  // decimal? | Optional; How many video frames per second to be scanned. Minimum value is 0.05 (1 frame per 20 seconds), maximum is 1. Default is 0.33 frame per second (1 frame scanned every 3 seconds). Maximum of 1000 total frames can be scanned, potentially adjusting the framerate for longer videos. (optional) 

            try
            {
                // Scan a Video for NSFW content.
                NsfwResult result = apiInstance.VideoScanForNsfw(inputFile, fileUrl, framesPerSecond);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoScanForNsfw: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being scanned. Use this option for files larger than 2GB. | [optional] 
 **framesPerSecond** | **decimal?**| Optional; How many video frames per second to be scanned. Minimum value is 0.05 (1 frame per 20 seconds), maximum is 1. Default is 0.33 frame per second (1 frame scanned every 3 seconds). Maximum of 1000 total frames can be scanned, potentially adjusting the framerate for longer videos. | [optional] 

### Return type

[**NsfwResult**](NsfwResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videosplitvideo"></a>
# **VideoSplitVideo**
> SplitVideoResult VideoSplitVideo (DateTime? splitTime, System.IO.Stream inputFile = null, string fileUrl = null, DateTime? timeSpan = null)

Split a Video into Two Shorter Videos

Cuts a video into two videos based on the specified start time. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class VideoSplitVideoExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VideoApi();
            var splitTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Specify the desired time at which to split the video in TimeSpan format.
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var timeSpan = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional; Specify the desired length of the second video in TimeSpan format. Leave blank to include the rest of the video. Maximum time is 4 hours. (optional) 

            try
            {
                // Split a Video into Two Shorter Videos
                SplitVideoResult result = apiInstance.VideoSplitVideo(splitTime, inputFile, fileUrl, timeSpan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VideoApi.VideoSplitVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **splitTime** | **DateTime?**| Specify the desired time at which to split the video in TimeSpan format. | 
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **timeSpan** | **DateTime?**| Optional; Specify the desired length of the second video in TimeSpan format. Leave blank to include the rest of the video. Maximum time is 4 hours. | [optional] 

### Return type

[**SplitVideoResult**](SplitVideoResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

