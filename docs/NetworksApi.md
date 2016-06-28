# IO.Vericred.Api.NetworksApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListNetworks**](NetworksApi.md#listnetworks) | **GET** /networks | Networks


# **ListNetworks**
> NetworkSearchResponse ListNetworks (string carrierId, int? page = null, int? perPage = null)

Networks

A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members. This endpoint is paginated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class ListNetworksExample
    {
        public void main()
        {
            
            // Configure API key authorization: Vericred-Api-Key
            Configuration.Default.ApiKey.Add('Vericred-Api-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('Vericred-Api-Key', 'Bearer');

            var apiInstance = new NetworksApi();
            var carrierId = 33333;  // string | Carrier HIOS Issuer ID
            var page = 1;  // int? | Page of paginated response (optional) 
            var perPage = 1;  // int? | Responses per page (optional) 

            try
            {
                // Networks
                NetworkSearchResponse result = apiInstance.ListNetworks(carrierId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworksApi.ListNetworks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**| Carrier HIOS Issuer ID | 
 **page** | **int?**| Page of paginated response | [optional] 
 **perPage** | **int?**| Responses per page | [optional] 

### Return type

[**NetworkSearchResponse**](NetworkSearchResponse.md)

### Authorization

[Vericred-Api-Key](../README.md#Vericred-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

