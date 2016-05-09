# IO.Vericred.Api.ZipCountiesApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ZipCountiesGet**](ZipCountiesApi.md#zipcountiesget) | **GET** /zip_counties | Find Zip Counties by Zip Code


# **ZipCountiesGet**
> InlineResponse2002 ZipCountiesGet (string zipPrefix)

Find Zip Counties by Zip Code

### Finding Zip Code and Fips Code  Our `Plan` endpoints require a zip code and a fips (county) code.  This is because plan pricing requires both of these elements.  Users are unlikely to know their fips code, so we provide this endpoint to look up a `ZipCounty` by zip code and return both the selected zip and fips codes.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class ZipCountiesGetExample
    {
        public void main()
        {
            
            var apiInstance = new ZipCountiesApi();
            var zipPrefix = zipPrefix_example;  // string | Partial five-digit Zip

            try
            {
                // Find Zip Counties by Zip Code
                InlineResponse2002 result = apiInstance.ZipCountiesGet(zipPrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCountiesApi.ZipCountiesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipPrefix** | **string**| Partial five-digit Zip | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

