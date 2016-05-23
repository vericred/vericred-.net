# IO.Vericred.Api.DrugsApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDrugCoverages**](DrugsApi.md#getdrugcoverages) | **GET** /drug_packages/{ndc_package_code}/coverages | Search for DrugCoverages
[**ListDrugs**](DrugsApi.md#listdrugs) | **GET** /drugs | Drug Search


# **GetDrugCoverages**
> DrugCoverageResponse GetDrugCoverages (string ndcPackageCode, string audience, string stateCode, string vericredApiKey = null)

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
            
            var apiInstance = new DrugsApi();
            var ndcPackageCode = 12345-4321-11;  // string | NDC package code
            var audience = individual;  // string | Two-character state code
            var stateCode = NY;  // string | Two-character state code
            var vericredApiKey = api-doc-key;  // string | API Key (optional) 

            try
            {
                // Search for DrugCoverages
                DrugCoverageResponse result = apiInstance.GetDrugCoverages(ndcPackageCode, audience, stateCode, vericredApiKey);
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
 **audience** | **string**| Two-character state code | 
 **stateCode** | **string**| Two-character state code | 
 **vericredApiKey** | **string**| API Key | [optional] 

### Return type

[**DrugCoverageResponse**](DrugCoverageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ListDrugs**
> DrugSearchResponse ListDrugs (string searchTerm, string vericredApiKey = null)

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
            
            var apiInstance = new DrugsApi();
            var searchTerm = Zyrtec;  // string | Full or partial proprietary name of drug
            var vericredApiKey = api-doc-key;  // string | API Key (optional) 

            try
            {
                // Drug Search
                DrugSearchResponse result = apiInstance.ListDrugs(searchTerm, vericredApiKey);
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
 **vericredApiKey** | **string**| API Key | [optional] 

### Return type

[**DrugSearchResponse**](DrugSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
