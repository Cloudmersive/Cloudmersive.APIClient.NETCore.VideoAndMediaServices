# Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api.AudioApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AudioConvertToAac**](AudioApi.md#audioconverttoaac) | **POST** /video/convert/to/aac | Convert Audio File to AAC format.
[**AudioConvertToM4a**](AudioApi.md#audioconverttom4a) | **POST** /video/convert/to/m4a | Convert Audio File to M4A format.
[**AudioConvertToMp3**](AudioApi.md#audioconverttomp3) | **POST** /video/convert/to/mp3 | Convert Audio File to MP3 format.
[**AudioConvertToWav**](AudioApi.md#audioconverttowav) | **POST** /video/convert/to/wav | Convert Audio File to WAV format.


<a name="audioconverttoaac"></a>
# **AudioConvertToAac**
> byte[] AudioConvertToAac (System.IO.Stream inputFile = null, string fileUrl = null, int? bitRate = null)

Convert Audio File to AAC format.

Automatically detect audio file format and convert it to AAC format. Supports many input audio formats, including AAC, FLAC, M4A, MP2, MP3, OGG, WMA, and WAV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class AudioConvertToAacExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of an audio file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **bitRate** | **int?**| Optional; Specify the desired bitrate of the converted audio file in kilobytes per second (kB/s). Value may be between 48 and 1,411. By default, the optimal bitrate will be chosen automatically. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="audioconverttom4a"></a>
# **AudioConvertToM4a**
> byte[] AudioConvertToM4a (System.IO.Stream inputFile = null, string fileUrl = null, int? bitRate = null)

Convert Audio File to M4A format.

Automatically detect audio file format and convert it to M4A format. Supports many input audio formats, including AAC, FLAC, M4A, MP2, MP3, OGG, WMA, and WAV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class AudioConvertToM4aExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AudioApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of an audio file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var bitRate = 56;  // int? | Optional; Specify the desired bitrate of the converted audio file in kilobytes per second (kB/s). Value may be between 48 and 1,411. By default, the optimal bitrate will be chosen automatically. (optional) 

            try
            {
                // Convert Audio File to M4A format.
                byte[] result = apiInstance.AudioConvertToM4a(inputFile, fileUrl, bitRate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AudioApi.AudioConvertToM4a: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of an audio file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **bitRate** | **int?**| Optional; Specify the desired bitrate of the converted audio file in kilobytes per second (kB/s). Value may be between 48 and 1,411. By default, the optimal bitrate will be chosen automatically. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="audioconverttomp3"></a>
# **AudioConvertToMp3**
> byte[] AudioConvertToMp3 (System.IO.Stream inputFile = null, string fileUrl = null, int? bitRate = null)

Convert Audio File to MP3 format.

Automatically detect audio file format and convert it to MP3 format. Supports many input audio formats, including AAC, FLAC, M4A, MP2, MP3, OGG, WMA, and WAV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class AudioConvertToMp3Example
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AudioApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of an audio file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var bitRate = 56;  // int? | Optional; Specify the desired bitrate of the converted audio file in kilobytes per second (kB/s). Value may be between 48 and 1,411. By default, the optimal bitrate will be chosen automatically. (optional) 

            try
            {
                // Convert Audio File to MP3 format.
                byte[] result = apiInstance.AudioConvertToMp3(inputFile, fileUrl, bitRate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AudioApi.AudioConvertToMp3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of an audio file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **bitRate** | **int?**| Optional; Specify the desired bitrate of the converted audio file in kilobytes per second (kB/s). Value may be between 48 and 1,411. By default, the optimal bitrate will be chosen automatically. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="audioconverttowav"></a>
# **AudioConvertToWav**
> byte[] AudioConvertToWav (System.IO.Stream inputFile = null, string fileUrl = null, decimal? sampleRate = null)

Convert Audio File to WAV format.

Automatically detect audio file format and convert it to WAV format. Supports many input audio formats, including AAC, FLAC, M4A, MP2, MP3, OGG, WMA, and WAV. Uses 1 API call per 10 MB of file size. Also uses 1 API call per additional minute of processing time over 5 minutes, up to a maximum of 25 minutes total processing time. Maximum output file size is 50GB.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Api;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model;

namespace Example
{
    public class AudioConvertToWavExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AudioApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on. (optional) 
            var fileUrl = fileUrl_example;  // string | Optional; URL of an audio file being used for conversion. Use this option for files larger than 2GB. (optional) 
            var sampleRate = 8.14;  // decimal? | Optional; Specify the desired sample rate of the converted audio file in kHz. Value may be between 8 and 96. Standard for audio CDs is 44.1, while DVD audio standard is 48. By default, the optimal sample rate will be chosen automatically. (optional) 

            try
            {
                // Convert Audio File to WAV format.
                byte[] result = apiInstance.AudioConvertToWav(inputFile, fileUrl, sampleRate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AudioApi.AudioConvertToWav: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | [optional] 
 **fileUrl** | **string**| Optional; URL of an audio file being used for conversion. Use this option for files larger than 2GB. | [optional] 
 **sampleRate** | **decimal?**| Optional; Specify the desired sample rate of the converted audio file in kHz. Value may be between 8 and 96. Standard for audio CDs is 44.1, while DVD audio standard is 48. By default, the optimal sample rate will be chosen automatically. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

