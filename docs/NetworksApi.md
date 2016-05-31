# IO.Vericred.Api.NetworksApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListNetworks**](NetworksApi.md#listnetworks) | **GET** /networks | Networks


# **ListNetworks**
> NetworkSearchResponse ListNetworks (string carrierId)

Networks

A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members.

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
            
            var apiInstance = new NetworksApi();
            var carrierId = 33333;  // string | Carrier HIOS Issuer ID

            try
            {
                // Networks
                NetworkSearchResponse result = apiInstance.ListNetworks(carrierId);
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

### Return type

[**NetworkSearchResponse**](NetworkSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

