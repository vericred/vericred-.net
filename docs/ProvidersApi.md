# IO.Vericred.Api.ProvidersApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProvidersGet**](ProvidersApi.md#providersget) | **GET** /providers | Find providers by term and zip code
[**ProvidersNpiGet**](ProvidersApi.md#providersnpiget) | **GET** /providers/{npi} | Find a specific Provider


# **ProvidersGet**
> InlineResponse200 ProvidersGet (string searchTerm, string zipCode, string acceptsInsurance = null, List<string> hiosIds = null, string page = null, string perPage = null, string radius = null)

Find providers by term and zip code

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
    public class ProvidersGetExample
    {
        public void main()
        {
            
            var apiInstance = new ProvidersApi();
            var searchTerm = searchTerm_example;  // string | String to search by
            var zipCode = zipCode_example;  // string | Zip Code to search near
            var acceptsInsurance = acceptsInsurance_example;  // string | Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true (optional) 
            var hiosIds = new List<string>(); // List<string> | HIOS id of one or more plans (optional) 
            var page = page_example;  // string | Page number (optional) 
            var perPage = perPage_example;  // string | Number of records to return per page (optional) 
            var radius = radius_example;  // string | Radius (in miles) to use to limit results (optional) 

            try
            {
                // Find providers by term and zip code
                InlineResponse200 result = apiInstance.ProvidersGet(searchTerm, zipCode, acceptsInsurance, hiosIds, page, perPage, radius);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchTerm** | **string**| String to search by | 
 **zipCode** | **string**| Zip Code to search near | 
 **acceptsInsurance** | **string**| Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true | [optional] 
 **hiosIds** | [**List<string>**](string.md)| HIOS id of one or more plans | [optional] 
 **page** | **string**| Page number | [optional] 
 **perPage** | **string**| Number of records to return per page | [optional] 
 **radius** | **string**| Radius (in miles) to use to limit results | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ProvidersNpiGet**
> InlineResponse2001 ProvidersNpiGet (string npi)

Find a specific Provider

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
    public class ProvidersNpiGetExample
    {
        public void main()
        {
            
            var apiInstance = new ProvidersApi();
            var npi = npi_example;  // string | NPI number

            try
            {
                // Find a specific Provider
                InlineResponse2001 result = apiInstance.ProvidersNpiGet(npi);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersNpiGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **npi** | **string**| NPI number | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

