# Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api.VideoApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VideoConvertToGif**](VideoApi.md#videoconverttogif) | **POST** /video/convert/to/gif | Convert Video to Animated GIF format.
[**VideoConvertToMov**](VideoApi.md#videoconverttomov) | **POST** /video/convert/to/mov | Convert Video to MOV format.
[**VideoConvertToMp4**](VideoApi.md#videoconverttomp4) | **POST** /video/convert/to/mp4 | Convert Video to MP4 format.
[**VideoConvertToWebm**](VideoApi.md#videoconverttowebm) | **POST** /video/convert/to/webm | Convert Video to WEBM format.
[**VideoGetInfo**](VideoApi.md#videogetinfo) | **POST** /video/convert/get-info | Get detailed information about a video or audio file


<a name="videoconverttogif"></a>
# **VideoConvertToGif**
> byte[] VideoConvertToGif (System.IO.Stream inputFile, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, bool? preserveAspectRatio = null, int? frameRate = null, bool? extendProcessingTime = null, DateTime? startTime = null, DateTime? timeSpan = null)

Convert Video to Animated GIF format.

Automatically detect video file format and convert it to animated GIF format. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Maximum output file size is 50GB. Default height is 250 pixels, while preserving the video's aspect ratio.

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
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to 250 pixels. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to 250 pixels. (optional) 
            var preserveAspectRatio = true;  // bool? | Optional; If false, the original video's aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to 24 frames per second. (optional) 
            var extendProcessingTime = true;  // bool? | Optional; If true, will allow additional processing time for the video file conversion, using one API call per additional minute over the 5 minute default processing time, up to a maximum of 25 total minutes. This is generally necessary for files larger than 500 MB or longer than 30 minutes. (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional; Specify the desired starting time of the GIF video in TimeSpan format. (optional) 
            var timeSpan = 2013-10-20T19:20:30+01:00;  // DateTime? | Optional; Specify the desired length of the GIF video in TimeSpan format. Limit is 30 minutes. (optional) 

            try
            {
                // Convert Video to Animated GIF format.
                byte[] result = apiInstance.VideoConvertToGif(inputFile, fileUrl, maxWidth, maxHeight, preserveAspectRatio, frameRate, extendProcessingTime, startTime, timeSpan);
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
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to 250 pixels. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to 250 pixels. | [optional] 
 **preserveAspectRatio** | **bool?**| Optional; If false, the original video&#39;s aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to 24 frames per second. | [optional] 
 **extendProcessingTime** | **bool?**| Optional; If true, will allow additional processing time for the video file conversion, using one API call per additional minute over the 5 minute default processing time, up to a maximum of 25 total minutes. This is generally necessary for files larger than 500 MB or longer than 30 minutes. | [optional] 
 **startTime** | **DateTime?**| Optional; Specify the desired starting time of the GIF video in TimeSpan format. | [optional] 
 **timeSpan** | **DateTime?**| Optional; Specify the desired length of the GIF video in TimeSpan format. Limit is 30 minutes. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoconverttomov"></a>
# **VideoConvertToMov**
> byte[] VideoConvertToMov (System.IO.Stream inputFile, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, bool? preserveAspectRatio = null, int? frameRate = null, int? quality = null, bool? extendProcessingTime = null)

Convert Video to MOV format.

Automatically detect video file format and convert it to MOV format. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Maximum output file size is 50GB.

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
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. (optional) 
            var preserveAspectRatio = true;  // bool? | Optional; If false, the original video's aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to original video frame rate. (optional) 
            var quality = 56;  // int? | Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. (optional) 
            var extendProcessingTime = true;  // bool? | Optional; If true, will allow additional processing time for the video file conversion, using one API call per additional minute over the 5 minute default processing time, up to a maximum of 25 total minutes. This is generally necessary for files larger than 500 MB or longer than 30 minutes. (optional) 

            try
            {
                // Convert Video to MOV format.
                byte[] result = apiInstance.VideoConvertToMov(inputFile, fileUrl, maxWidth, maxHeight, preserveAspectRatio, frameRate, quality, extendProcessingTime);
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
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. | [optional] 
 **preserveAspectRatio** | **bool?**| Optional; If false, the original video&#39;s aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to original video frame rate. | [optional] 
 **quality** | **int?**| Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. | [optional] 
 **extendProcessingTime** | **bool?**| Optional; If true, will allow additional processing time for the video file conversion, using one API call per additional minute over the 5 minute default processing time, up to a maximum of 25 total minutes. This is generally necessary for files larger than 500 MB or longer than 30 minutes. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoconverttomp4"></a>
# **VideoConvertToMp4**
> byte[] VideoConvertToMp4 (System.IO.Stream inputFile, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, bool? preserveAspectRatio = null, int? frameRate = null, int? quality = null, bool? extendProcessingTime = null)

Convert Video to MP4 format.

Automatically detect video file format and convert it to MP4 format. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Maximum output file size is 50GB.

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
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. (optional) 
            var preserveAspectRatio = true;  // bool? | Optional; If false, the original video's aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to original video frame rate. (optional) 
            var quality = 56;  // int? | Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. (optional) 
            var extendProcessingTime = true;  // bool? | Optional; If true, will allow additional processing time for the video file conversion, using one API call per additional minute over the 5 minute default processing time, up to a maximum of 25 total minutes. This is generally necessary for files larger than 500 MB or longer than 30 minutes. (optional) 

            try
            {
                // Convert Video to MP4 format.
                byte[] result = apiInstance.VideoConvertToMp4(inputFile, fileUrl, maxWidth, maxHeight, preserveAspectRatio, frameRate, quality, extendProcessingTime);
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
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. | [optional] 
 **preserveAspectRatio** | **bool?**| Optional; If false, the original video&#39;s aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to original video frame rate. | [optional] 
 **quality** | **int?**| Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. | [optional] 
 **extendProcessingTime** | **bool?**| Optional; If true, will allow additional processing time for the video file conversion, using one API call per additional minute over the 5 minute default processing time, up to a maximum of 25 total minutes. This is generally necessary for files larger than 500 MB or longer than 30 minutes. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoconverttowebm"></a>
# **VideoConvertToWebm**
> byte[] VideoConvertToWebm (System.IO.Stream inputFile, string fileUrl = null, int? maxWidth = null, int? maxHeight = null, bool? preserveAspectRatio = null, int? frameRate = null, int? quality = null, bool? extendProcessingTime = null)

Convert Video to WEBM format.

Automatically detect video file format and convert it to WEBM format. Supports many input video formats, including AVI, ASF, FLV, MP4, MPEG/MPG, Matroska/WEBM, 3G2, OGV, MKV, M4V and MOV. Uses 1 API call per 10 MB of file size. Maximum output file size is 50GB.

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
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var maxWidth = 56;  // int? | Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. (optional) 
            var maxHeight = 56;  // int? | Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. (optional) 
            var preserveAspectRatio = true;  // bool? | Optional; If false, the original video's aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. (optional) 
            var frameRate = 56;  // int? | Optional; Specify the frame rate of the output video. Defaults to original video frame rate. (optional) 
            var quality = 56;  // int? | Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. (optional) 
            var extendProcessingTime = true;  // bool? | Optional; If true, will allow additional processing time for the video file conversion, using one API call per additional minute over the 5 minute default processing time, up to a maximum of 25 total minutes. This is generally necessary for files larger than 500 MB or longer than 30 minutes. (optional) 

            try
            {
                // Convert Video to WEBM format.
                byte[] result = apiInstance.VideoConvertToWebm(inputFile, fileUrl, maxWidth, maxHeight, preserveAspectRatio, frameRate, quality, extendProcessingTime);
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
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **maxWidth** | **int?**| Optional; Maximum width of the output video, up to the original video width. Defaults to original video width. | [optional] 
 **maxHeight** | **int?**| Optional; Maximum height of the output video, up to the original video width. Defaults to original video height. | [optional] 
 **preserveAspectRatio** | **bool?**| Optional; If false, the original video&#39;s aspect ratio will not be preserved, allowing customization of the aspect ratio using maxWidth and maxHeight, potentially skewing the video. Default is true. | [optional] 
 **frameRate** | **int?**| Optional; Specify the frame rate of the output video. Defaults to original video frame rate. | [optional] 
 **quality** | **int?**| Optional; Specify the quality of the output video, where 100 is lossless and 1 is the lowest possible quality with highest compression. Default is 50. | [optional] 
 **extendProcessingTime** | **bool?**| Optional; If true, will allow additional processing time for the video file conversion, using one API call per additional minute over the 5 minute default processing time, up to a maximum of 25 total minutes. This is generally necessary for files larger than 500 MB or longer than 30 minutes. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videogetinfo"></a>
# **VideoGetInfo**
> byte[] VideoGetInfo (System.IO.Stream inputFile, string fileUrl = null)

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
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var fileUrl = fileUrl_example;  // string | Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. (optional) 

            try
            {
                // Get detailed information about a video or audio file
                byte[] result = apiInstance.VideoGetInfo(inputFile, fileUrl);
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
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **fileUrl** | **string**| Optional; URL of a video file being used for conversion. Use this option for files larger than 2GB. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

