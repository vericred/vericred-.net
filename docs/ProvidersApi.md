# IO.Vericred.Api.ProvidersApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProvider**](ProvidersApi.md#getprovider) | **GET** /providers/{npi} | Find a Provider
[**GetProviders**](ProvidersApi.md#getproviders) | **POST** /providers/search | Find Providers
[**GetProviders_0**](ProvidersApi.md#getproviders_0) | **POST** /providers/search/geocode | Find Providers


<a name="getprovider"></a>
# **GetProvider**
> ProviderShowResponse GetProvider (string npi, string year = null, string state = null)

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
            
            // Configure API key authorization: Vericred-Api-Key
            Configuration.Default.ApiKey.Add("Vericred-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Vericred-Api-Key", "Bearer");

            var apiInstance = new ProvidersApi();
            var npi = 1234567890;  // string | NPI number
            var year = 2016;  // string | Only show plan ids for the given year (optional) 
            var state = NY;  // string | Only show plan ids for the given state (optional) 

            try
            {
                // Find a Provider
                ProviderShowResponse result = apiInstance.GetProvider(npi, year, state);
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
 **year** | **string**| Only show plan ids for the given year | [optional] 
 **state** | **string**| Only show plan ids for the given state | [optional] 

### Return type

[**ProviderShowResponse**](ProviderShowResponse.md)

### Authorization

[Vericred-Api-Key](../README.md#Vericred-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproviders"></a>
# **GetProviders**
> ProvidersSearchResponse GetProviders (RequestProvidersSearch body)

Find Providers

### Provider Details All searches can take a `search_term`, which is used as a component in the score (and thus the ranking/order) of the results.  This is combined with the proximity to the location in ranking results. For example, we would want \"Dr. John Smith\" who is 5 miles away from a given Zip Code to appear before \"Dr. John Smith\" who is 100 miles away.  The weighting also allows for non-exact matches.  In our prior example, we would want \"Dr. Jon Smith\" who is 2 miles away to appear before the exact match \"Dr. John Smith\" who is 100 miles away because it is more likely that the user just entered an incorrect name.  The free text search also supports Specialty name search and \"body part\" Specialty name search.  So, searching \"John Smith nose\" would return \"Dr. John Smith\", the ENT Specialist before \"Dr. John Smith\" the Internist.  In addition, we can filter `Providers` by whether or not they accept *any* insurance.  Our data set includes over 4 million `Providers`, some of whom do not accept any insurance at all.  This filter makes it more likely that the user will find his or her practitioner in some cases.  We can also use `min_score` to omit less relevant results.  This makes sense in the case where your application wants to display *all* of the results returned regardless of how many there are.  Otherwise, using our default `min_score` and pagination should be sufficient.  ### Location Information  All `Provider` searches that do *not* specify `plan_ids` or `network_ids`require some type of location information. We use this information either to weight results or to filter results, depending on the type.  #### Zip Code When providing the `zip_code` parameter, we order the `Providers` returned based on their score, which incorporates their proximity to the given Zip Code and the closeness of match to the search text.  If a `radius` is also provided, we filter out `Providers` who are outside of that radius from the center of the Zip Code provided  #### Polygon When providing the `polygon` parameter, we filter providers who are outside the bounds of the shape provided.  This is mutually exclusive with `zip_code` and `radius`.  ### Plan/Network Information We can also filter based on `Plan` and `Network` participation.  These filters are mutually exclusive and return the union of the resulting sets for each `Plan` or `Network`.  I.e. if you provider Plan A and Plan B, you will receive `Providers` who accept *either* `Plan`.  The same is true for `Networks`.  ### Examples  *Find Dr. Foo near Brooklyn*  `{ \"search_term\": \"Foo\", \"zip_code\": \"11215\" }`  *Find all Providers within 5 miles of Brooklyn who accept a Plan*  `{ \"zip_code\": \"11215\", \"radius\": 5, \"hios_ids\": [\"88582NY0230001\"] }`  *Find all providers on a map of Brooklyn ordered by a combination of proximity to the center point of the map and relevance to the search term \"ENT\"*  ``` {   \"polygon\": [       {\"lon\":-74.0126609802,\"lat\":40.6275684851 },       {\"lon\":-74.0126609802,\"lat\":40.7097269508 },       {\"lon\":-73.9367866516,\"lat\":40.7097269508 },       {\"lon\":-73.9367866516,\"lat\":40.6275684851 }   ],   \"search_term\" : \"ENT\" } ``` 

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
            
            // Configure API key authorization: Vericred-Api-Key
            Configuration.Default.ApiKey.Add("Vericred-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Vericred-Api-Key", "Bearer");

            var apiInstance = new ProvidersApi();
            var body = new RequestProvidersSearch(); // RequestProvidersSearch | 

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
 **body** | [**RequestProvidersSearch**](RequestProvidersSearch.md)|  | 

### Return type

[**ProvidersSearchResponse**](ProvidersSearchResponse.md)

### Authorization

[Vericred-Api-Key](../README.md#Vericred-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproviders_0"></a>
# **GetProviders_0**
> ProvidersGeocodeResponse GetProviders_0 (RequestProvidersSearch body)

Find Providers

### Provider Details All searches can take a `search_term`, which is used as a component in the score (and thus the ranking/order) of the results.  This is combined with the proximity to the location in ranking results. For example, we would want \"Dr. John Smith\" who is 5 miles away from a given Zip Code to appear before \"Dr. John Smith\" who is 100 miles away.  The weighting also allows for non-exact matches.  In our prior example, we would want \"Dr. Jon Smith\" who is 2 miles away to appear before the exact match \"Dr. John Smith\" who is 100 miles away because it is more likely that the user just entered an incorrect name.  The free text search also supports Specialty name search and \"body part\" Specialty name search.  So, searching \"John Smith nose\" would return \"Dr. John Smith\", the ENT Specialist before \"Dr. John Smith\" the Internist.  In addition, we can filter `Providers` by whether or not they accept *any* insurance.  Our data set includes over 4 million `Providers`, some of whom do not accept any insurance at all.  This filter makes it more likely that the user will find his or her practitioner in some cases.  We can also use `min_score` to omit less relevant results.  This makes sense in the case where your application wants to display *all* of the results returned regardless of how many there are.  Otherwise, using our default `min_score` and pagination should be sufficient.  ### Location Information  All `Provider` searches that do *not* specify `plan_ids` or `network_ids`require some type of location information. We use this information either to weight results or to filter results, depending on the type.  #### Zip Code When providing the `zip_code` parameter, we order the `Providers` returned based on their score, which incorporates their proximity to the given Zip Code and the closeness of match to the search text.  If a `radius` is also provided, we filter out `Providers` who are outside of that radius from the center of the Zip Code provided  #### Polygon When providing the `polygon` parameter, we filter providers who are outside the bounds of the shape provided.  This is mutually exclusive with `zip_code` and `radius`.  ### Plan/Network Information We can also filter based on `Plan` and `Network` participation.  These filters are mutually exclusive and return the union of the resulting sets for each `Plan` or `Network`.  I.e. if you provider Plan A and Plan B, you will receive `Providers` who accept *either* `Plan`.  The same is true for `Networks`.  ### Examples  *Find Dr. Foo near Brooklyn*  `{ \"search_term\": \"Foo\", \"zip_code\": \"11215\" }`  *Find all Providers within 5 miles of Brooklyn who accept a Plan*  `{ \"zip_code\": \"11215\", \"radius\": 5, \"hios_ids\": [\"88582NY0230001\"] }`  *Find all providers on a map of Brooklyn ordered by a combination of proximity to the center point of the map and relevance to the search term \"ENT\"*  ``` {   \"polygon\": [       {\"lon\":-74.0126609802,\"lat\":40.6275684851 },       {\"lon\":-74.0126609802,\"lat\":40.7097269508 },       {\"lon\":-73.9367866516,\"lat\":40.7097269508 },       {\"lon\":-73.9367866516,\"lat\":40.6275684851 }   ],   \"search_term\" : \"ENT\" } ``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class GetProviders_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: Vericred-Api-Key
            Configuration.Default.ApiKey.Add("Vericred-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Vericred-Api-Key", "Bearer");

            var apiInstance = new ProvidersApi();
            var body = new RequestProvidersSearch(); // RequestProvidersSearch | 

            try
            {
                // Find Providers
                ProvidersGeocodeResponse result = apiInstance.GetProviders_0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetProviders_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestProvidersSearch**](RequestProvidersSearch.md)|  | 

### Return type

[**ProvidersGeocodeResponse**](ProvidersGeocodeResponse.md)

### Authorization

[Vericred-Api-Key](../README.md#Vericred-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

