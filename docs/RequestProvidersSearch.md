# IO.Vericred.Model.RequestProvidersSearch
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptsInsurance** | **bool?** | Limit results to Providers who accept at least one insurance         plan.  Note that the inverse of this filter is not supported and         any value will evaluate to true | [optional] 
**HiosIds** | **List&lt;string&gt;** | List of HIOS ids | [optional] 
**MinScore** | **decimal?** | Minimum search threshold to be included in the results | [optional] 
**Page** | **int?** | Page number | [optional] 
**PerPage** | **int?** | Number of records to return per page | [optional] 
**Radius** | **int?** | Radius (in miles) to use to limit results | [optional] 
**SearchTerm** | **string** | String to search by | [optional] 
**ZipCode** | **string** | Zip Code to search near | [optional] 
**Type** | **string** | Either organization or individual | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

