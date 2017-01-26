# IO.Vericred.Model.RequestProvidersSearch
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptsInsurance** | **bool?** | Limit results to Providers who accept at least one insurance         plan.  Note that the inverse of this filter is not supported and         any value will evaluate to true | [optional] 
**MinScore** | **decimal?** | Minimum search threshold to be included in the results | [optional] 
**NetworkIds** | **List&lt;int?&gt;** | List of Vericred network ids | [optional] 
**Page** | **int?** | Page number | [optional] 
**PerPage** | **int?** | Number of records to return per page | [optional] 
**Polygon** | **int?** | Define a custom search polygon, mutually exclusive with zip_code search | [optional] 
**Radius** | **int?** | Radius (in miles) to use to limit results | [optional] 
**SearchTerm** | **string** | String to search by | [optional] 
**Sort** | **string** | specify sort mode (distance or random) | [optional] 
**SortSeed** | **int?** | Seed value for random sort. Randomly-ordered searches with the same seed return results in consistent order. | [optional] 
**Type** | **string** | Either organization or individual | [optional] 
**ZipCode** | **string** | Zip Code to search near | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

