# IO.Vericred.Model.RequestPlanFind
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applicants** | [**List&lt;RequestPlanFindApplicant&gt;**](RequestPlanFindApplicant.md) | Applicants for desired plans. | [optional] 
**EnrollmentDate** | **string** | Date of enrollment | [optional] 
**DrugPackages** | [**List&lt;DrugPackage&gt;**](DrugPackage.md) | National Drug Code Package Id | [optional] 
**FipsCode** | **string** | County code to determine eligibility | [optional] 
**HouseholdIncome** | **int?** | Total household income. | [optional] 
**HouseholdSize** | **int?** | Number of people living in household. | [optional] 
**Market** | **string** | Type of plan to search for. | [optional] 
**Providers** | [**List&lt;RequestPlanFindProvider&gt;**](RequestPlanFindProvider.md) | List of providers to search for. | [optional] 
**Page** | **int?** | Selected page of paginated response. | [optional] 
**PerPage** | **int?** | Results per page of response. | [optional] 
**Sort** | **string** | Sort responses by plan field. | [optional] 
**ZipCode** | **string** | 5-digit zip code - this helps determine pricing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

