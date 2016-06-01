# IO.Vericred.Api.ProvidersApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProvider**](ProvidersApi.md#getprovider) | **GET** /providers/{npi} | Find a Provider
[**GetProviders**](ProvidersApi.md#getproviders) | **POST** /providers/search | Find Providers


# **GetProvider**
> ProviderShowResponse GetProvider (string npi, string vericredApiKey = null)

Find a Provider

To retrieve a specific provider, just perform a GET using his NPI number

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class GetProviderExample
    {
        public void main()
        {
            
            var apiInstance = new ProvidersApi();
            var npi = 1234567890;  // string | NPI number
            var vericredApiKey = api-doc-key;  // string | API Key (optional) 

            try
            {
                // Find a Provider
                ProviderShowResponse result = apiInstance.GetProvider(npi, vericredApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **npi** | **string**| NPI number | 
 **vericredApiKey** | **string**| API Key | [optional] 

### Return type

[**ProviderShowResponse**](ProviderShowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetProviders**
> ProvidersSearchResponse GetProviders (RequestProvidersSearch body = null)

Find Providers

All `Provider` searches require a `zip_code`, which we use for weighting the search results to favor `Provider`s that are near the user.  For example, we would want "Dr. John Smith" who is 5 miles away to appear before "Dr. John Smith" who is 100 miles away.  The weighting also allows for non-exact matches.  In our prior example, we would want "Dr. Jon Smith" who is 2 miles away to appear before the exact match "Dr. John Smith" who is 100 miles away because it is more likely that the user just entered an incorrect name.  The free text search also supports Specialty name search and "body part" Specialty name search.  So, searching "John Smith nose" would return "Dr. John Smith", the ENT Specialist before "Dr. John Smith" the Internist. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class GetProvidersExample
    {
        public void main()
        {
            
            var apiInstance = new ProvidersApi();
            var body = new RequestProvidersSearch(); // RequestProvidersSearch |  (optional) 

            try
            {
                // Find Providers
                ProvidersSearchResponse result = apiInstance.GetProviders(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestProvidersSearch**](RequestProvidersSearch.md)|  | [optional] 

### Return type

[**ProvidersSearchResponse**](ProvidersSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

