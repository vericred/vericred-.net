# IO.Vericred.Api.DrugPackagesApi

All URIs are relative to *https://api.vericred.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShowFormularyDrugPackageCoverage**](DrugPackagesApi.md#showformularydrugpackagecoverage) | **GET** /formularies/{formulary_id}/drug_packages/{ndc_package_code} | Formulary Drug Package Search


<a name="showformularydrugpackagecoverage"></a>
# **ShowFormularyDrugPackageCoverage**
> FormularyDrugPackageResponse ShowFormularyDrugPackageCoverage (string formularyId, string ndcPackageCode)

Formulary Drug Package Search

Search for coverage by Formulary and DrugPackage ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Vericred.Api;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace Example
{
    public class ShowFormularyDrugPackageCoverageExample
    {
        public void main()
        {
            
            // Configure API key authorization: Vericred-Api-Key
            Configuration.Default.ApiKey.Add("Vericred-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Vericred-Api-Key", "Bearer");

            var apiInstance = new DrugPackagesApi();
            var formularyId = 123;  // string | ID of the Formulary in question
            var ndcPackageCode = 07777-3105-01;  // string | ID of the DrugPackage in question

            try
            {
                // Formulary Drug Package Search
                FormularyDrugPackageResponse result = apiInstance.ShowFormularyDrugPackageCoverage(formularyId, ndcPackageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DrugPackagesApi.ShowFormularyDrugPackageCoverage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **formularyId** | **string**| ID of the Formulary in question | 
 **ndcPackageCode** | **string**| ID of the DrugPackage in question | 

### Return type

[**FormularyDrugPackageResponse**](FormularyDrugPackageResponse.md)

### Authorization

[Vericred-Api-Key](../README.md#Vericred-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

