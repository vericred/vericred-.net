# IO.Vericred.Api.NetworkSizesApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListStateNetworkSizes**](NetworkSizesApi.md#liststatenetworksizes) | **GET** /states/{state_id}/network_sizes | State Network Sizes
[**SearchNetworkSizes**](NetworkSizesApi.md#searchnetworksizes) | **POST** /network_sizes/search | Network Sizes


<a name="liststatenetworksizes"></a>
# **ListStateNetworkSizes**
> StateNetworkSizeResponse ListStateNetworkSizes (string stateId, int? page = null, int? perPage = null)

State Network Sizes

The number of in-network Providers for each network in a given state. This data is recalculated nightly.  The endpoint is paginated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class ListStateNetworkSizesExample
    {
        public void main()
        {
            
            // Configure API key authorization: Vericred-Api-Key
            Configuration.Default.ApiKey.Add("Vericred-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Vericred-Api-Key", "Bearer");

            var apiInstance = new NetworkSizesApi();
            var stateId = CA;  // string | State code
            var page = 1;  // int? | Page of paginated response (optional) 
            var perPage = 1;  // int? | Responses per page (optional) 

            try
            {
                // State Network Sizes
                StateNetworkSizeResponse result = apiInstance.ListStateNetworkSizes(stateId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkSizesApi.ListStateNetworkSizes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stateId** | **string**| State code | 
 **page** | **int?**| Page of paginated response | [optional] 
 **perPage** | **int?**| Responses per page | [optional] 

### Return type

[**StateNetworkSizeResponse**](StateNetworkSizeResponse.md)

### Authorization

[Vericred-Api-Key](../README.md#Vericred-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchnetworksizes"></a>
# **SearchNetworkSizes**
> StateNetworkSizeResponse SearchNetworkSizes (StateNetworkSizeRequest body)

Network Sizes

The number of in-network Providers for each network/state combination provided. This data is recalculated nightly.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class SearchNetworkSizesExample
    {
        public void main()
        {
            
            // Configure API key authorization: Vericred-Api-Key
            Configuration.Default.ApiKey.Add("Vericred-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Vericred-Api-Key", "Bearer");

            var apiInstance = new NetworkSizesApi();
            var body = new StateNetworkSizeRequest(); // StateNetworkSizeRequest | 

            try
            {
                // Network Sizes
                StateNetworkSizeResponse result = apiInstance.SearchNetworkSizes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkSizesApi.SearchNetworkSizes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StateNetworkSizeRequest**](StateNetworkSizeRequest.md)|  | 

### Return type

[**StateNetworkSizeResponse**](StateNetworkSizeResponse.md)

### Authorization

[Vericred-Api-Key](../README.md#Vericred-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

