# IO.Vericred.Api.ZipCountiesApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetZipCounties**](ZipCountiesApi.md#getzipcounties) | **GET** /zip_counties | Search for Zip Counties


# **GetZipCounties**
> ZipCountyResponse GetZipCounties (string zipPrefix, string vericredApiKey = null)

Search for Zip Counties

Our `Plan` endpoints require a zip code and a fips (county) code.  This is because plan pricing requires both of these elements.  Users are unlikely to know their fips code, so we provide this endpoint to look up a `ZipCounty` by zip code and return both the selected zip and fips codes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class GetZipCountiesExample
    {
        public void main()
        {
            
            var apiInstance = new ZipCountiesApi();
            var zipPrefix = 1002;  // string | Partial five-digit Zip
            var vericredApiKey = api-doc-key;  // string | API Key (optional) 

            try
            {
                // Search for Zip Counties
                ZipCountyResponse result = apiInstance.GetZipCounties(zipPrefix, vericredApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCountiesApi.GetZipCounties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipPrefix** | **string**| Partial five-digit Zip | 
 **vericredApiKey** | **string**| API Key | [optional] 

### Return type

[**ZipCountyResponse**](ZipCountyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

