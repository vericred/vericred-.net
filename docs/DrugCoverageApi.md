# IO.Vericred.Api.DrugCoverageApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DrugsNdcCoveragesGet**](DrugCoverageApi.md#drugsndccoveragesget) | **GET** /drugs/{ndc}/coverages | Find Drug Coverages for a given NDC


# **DrugsNdcCoveragesGet**
> List<DrugCoverage> DrugsNdcCoveragesGet (string ndc)

Find Drug Coverages for a given NDC

Drug Coverages are the specific tier level, quantity limit, prior authorization and step therapy for a given Drug/Plan combination.  This endpoint returns all DrugCoverages for a given Drug  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class DrugsNdcCoveragesGetExample
    {
        public void main()
        {
            
            var apiInstance = new DrugCoverageApi();
            var ndc = ndc_example;  // string | NDC for a drug

            try
            {
                // Find Drug Coverages for a given NDC
                List&lt;DrugCoverage&gt; result = apiInstance.DrugsNdcCoveragesGet(ndc);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DrugCoverageApi.DrugsNdcCoveragesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ndc** | **string**| NDC for a drug | 

### Return type

[**List<DrugCoverage>**](DrugCoverage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

