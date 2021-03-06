# IO.Vericred.Api.DrugsApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDrugCoverages**](DrugsApi.md#getdrugcoverages) | **GET** /drug_packages/{ndc_package_code}/coverages | Search for DrugCoverages
[**ListDrugs**](DrugsApi.md#listdrugs) | **GET** /drugs | Drug Search


<a name="getdrugcoverages"></a>
# **GetDrugCoverages**
> DrugCoverageResponse GetDrugCoverages (string ndcPackageCode, string audience, string stateCode)

Search for DrugCoverages

Drug Coverages are the specific tier level, quantity limit, prior authorization and step therapy for a given Drug/Plan combination. This endpoint returns all DrugCoverages for a given Drug

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class GetDrugCoveragesExample
    {
        public void main()
        {
            
            // Configure API key authorization: Vericred-Api-Key
            Configuration.Default.ApiKey.Add("Vericred-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Vericred-Api-Key", "Bearer");

            var apiInstance = new DrugsApi();
            var ndcPackageCode = 07777-3105-01;  // string | NDC package code
            var audience = individual;  // string | Plan Audience (individual or small_group)
            var stateCode = CA;  // string | Two-character state code

            try
            {
                // Search for DrugCoverages
                DrugCoverageResponse result = apiInstance.GetDrugCoverages(ndcPackageCode, audience, stateCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DrugsApi.GetDrugCoverages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ndcPackageCode** | **string**| NDC package code | 
 **audience** | **string**| Plan Audience (individual or small_group) | 
 **stateCode** | **string**| Two-character state code | 

### Return type

[**DrugCoverageResponse**](DrugCoverageResponse.md)

### Authorization

[Vericred-Api-Key](../README.md#Vericred-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdrugs"></a>
# **ListDrugs**
> DrugSearchResponse ListDrugs (string searchTerm)

Drug Search

Search for drugs by proprietary name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class ListDrugsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Vericred-Api-Key
            Configuration.Default.ApiKey.Add("Vericred-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Vericred-Api-Key", "Bearer");

            var apiInstance = new DrugsApi();
            var searchTerm = Zyrtec;  // string | Full or partial proprietary name of drug

            try
            {
                // Drug Search
                DrugSearchResponse result = apiInstance.ListDrugs(searchTerm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DrugsApi.ListDrugs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchTerm** | **string**| Full or partial proprietary name of drug | 

### Return type

[**DrugSearchResponse**](DrugSearchResponse.md)

### Authorization

[Vericred-Api-Key](../README.md#Vericred-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

