# Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model.NsfwResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the operation was successful, false otherwise | [optional] 
**HighestClassificationResult** | **string** | The highest NSFW classification of the video | [optional] 
**HighestScore** | **double?** | The highest NSFW score out of all frames scanned | [optional] 
**TotalRacyFrames** | **int?** | The total number of potentially \&quot;racy\&quot; frames. | [optional] 
**TotalNsfwFrames** | **int?** | The total number of frames with high probability of NSFW. | [optional] 
**TotalFrames** | **int?** | The total number of frames scanned | [optional] 
**NsfwScannedFrames** | [**List&lt;NsfwScannedFrame&gt;**](NsfwScannedFrame.md) | The NSFW scanning results for each frame | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

