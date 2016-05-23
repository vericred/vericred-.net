using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace IO.Vericred.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDrugsApi
    {
        #region Synchronous Operations

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndcPackageCode">NDC package code</param>
        /// <param name="audience">Two-character state code</param>
        /// <param name="stateCode">Two-character state code</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>DrugCoverageResponse</returns>
        DrugCoverageResponse GetDrugCoverages (string ndcPackageCode, string audience, string stateCode, string vericredApiKey = null);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndcPackageCode">NDC package code</param>
        /// <param name="audience">Two-character state code</param>
        /// <param name="stateCode">Two-character state code</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>ApiResponse of DrugCoverageResponse</returns>
        ApiResponse<DrugCoverageResponse> GetDrugCoveragesWithHttpInfo (string ndcPackageCode, string audience, string stateCode, string vericredApiKey = null);

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Full or partial proprietary name of drug</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>DrugSearchResponse</returns>
        DrugSearchResponse ListDrugs (string searchTerm, string vericredApiKey = null);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Full or partial proprietary name of drug</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>ApiResponse of DrugSearchResponse</returns>
        ApiResponse<DrugSearchResponse> ListDrugsWithHttpInfo (string searchTerm, string vericredApiKey = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndcPackageCode">NDC package code</param>
        /// <param name="audience">Two-character state code</param>
        /// <param name="stateCode">Two-character state code</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of DrugCoverageResponse</returns>
        System.Threading.Tasks.Task<DrugCoverageResponse> GetDrugCoveragesAsync (string ndcPackageCode, string audience, string stateCode, string vericredApiKey = null);

        /// <summary>
        /// Search for DrugCoverages
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndcPackageCode">NDC package code</param>
        /// <param name="audience">Two-character state code</param>
        /// <param name="stateCode">Two-character state code</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of ApiResponse (DrugCoverageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DrugCoverageResponse>> GetDrugCoveragesAsyncWithHttpInfo (string ndcPackageCode, string audience, string stateCode, string vericredApiKey = null);


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Full or partial proprietary name of drug</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of DrugSearchResponse</returns>
        System.Threading.Tasks.Task<DrugSearchResponse> ListDrugsAsync (string searchTerm, string vericredApiKey = null);

        /// <summary>
        /// Drug Search
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Full or partial proprietary name of drug</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of ApiResponse (DrugSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DrugSearchResponse>> ListDrugsAsyncWithHttpInfo (string searchTerm, string vericredApiKey = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DrugsApi : IDrugsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrugsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DrugsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrugsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DrugsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Search for DrugCoverages Drug Coverages are the specific tier level, quantity limit, prior authorization and step therapy for a given Drug/Plan combination. This endpoint returns all DrugCoverages for a given Drug
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndcPackageCode">NDC package code</param>
        /// <param name="audience">Two-character state code</param>
        /// <param name="stateCode">Two-character state code</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>DrugCoverageResponse</returns>
        public DrugCoverageResponse GetDrugCoverages (string ndcPackageCode, string audience, string stateCode, string vericredApiKey = null)
        {
             ApiResponse<DrugCoverageResponse> localVarResponse = GetDrugCoveragesWithHttpInfo(ndcPackageCode, audience, stateCode, vericredApiKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for DrugCoverages Drug Coverages are the specific tier level, quantity limit, prior authorization and step therapy for a given Drug/Plan combination. This endpoint returns all DrugCoverages for a given Drug
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndcPackageCode">NDC package code</param>
        /// <param name="audience">Two-character state code</param>
        /// <param name="stateCode">Two-character state code</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>ApiResponse of DrugCoverageResponse</returns>
        public ApiResponse< DrugCoverageResponse > GetDrugCoveragesWithHttpInfo (string ndcPackageCode, string audience, string stateCode, string vericredApiKey = null)
        {
            // verify the required parameter 'ndcPackageCode' is set
            if (ndcPackageCode == null)
                throw new ApiException(400, "Missing required parameter 'ndcPackageCode' when calling DrugsApi->GetDrugCoverages");
            // verify the required parameter 'audience' is set
            if (audience == null)
                throw new ApiException(400, "Missing required parameter 'audience' when calling DrugsApi->GetDrugCoverages");
            // verify the required parameter 'stateCode' is set
            if (stateCode == null)
                throw new ApiException(400, "Missing required parameter 'stateCode' when calling DrugsApi->GetDrugCoverages");

            var localVarPath = "/drug_packages/{ndc_package_code}/coverages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ndcPackageCode != null) localVarPathParams.Add("ndc_package_code", Configuration.ApiClient.ParameterToString(ndcPackageCode)); // path parameter
            if (audience != null) localVarQueryParams.Add("audience", Configuration.ApiClient.ParameterToString(audience)); // query parameter
            if (stateCode != null) localVarQueryParams.Add("state_code", Configuration.ApiClient.ParameterToString(stateCode)); // query parameter
            if (vericredApiKey != null) localVarHeaderParams.Add("Vericred-Api-Key", Configuration.ApiClient.ParameterToString(vericredApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDrugCoverages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDrugCoverages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DrugCoverageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DrugCoverageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DrugCoverageResponse)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndcPackageCode">NDC package code</param>
        /// <param name="audience">Two-character state code</param>
        /// <param name="stateCode">Two-character state code</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of DrugCoverageResponse</returns>
        public async System.Threading.Tasks.Task<DrugCoverageResponse> GetDrugCoveragesAsync (string ndcPackageCode, string audience, string stateCode, string vericredApiKey = null)
        {
             ApiResponse<DrugCoverageResponse> localVarResponse = await GetDrugCoveragesAsyncWithHttpInfo(ndcPackageCode, audience, stateCode, vericredApiKey);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndcPackageCode">NDC package code</param>
        /// <param name="audience">Two-character state code</param>
        /// <param name="stateCode">Two-character state code</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of ApiResponse (DrugCoverageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DrugCoverageResponse>> GetDrugCoveragesAsyncWithHttpInfo (string ndcPackageCode, string audience, string stateCode, string vericredApiKey = null)
        {
            // verify the required parameter 'ndcPackageCode' is set
            if (ndcPackageCode == null)
                throw new ApiException(400, "Missing required parameter 'ndcPackageCode' when calling DrugsApi->GetDrugCoverages");
            // verify the required parameter 'audience' is set
            if (audience == null)
                throw new ApiException(400, "Missing required parameter 'audience' when calling DrugsApi->GetDrugCoverages");
            // verify the required parameter 'stateCode' is set
            if (stateCode == null)
                throw new ApiException(400, "Missing required parameter 'stateCode' when calling DrugsApi->GetDrugCoverages");

            var localVarPath = "/drug_packages/{ndc_package_code}/coverages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ndcPackageCode != null) localVarPathParams.Add("ndc_package_code", Configuration.ApiClient.ParameterToString(ndcPackageCode)); // path parameter
            if (audience != null) localVarQueryParams.Add("audience", Configuration.ApiClient.ParameterToString(audience)); // query parameter
            if (stateCode != null) localVarQueryParams.Add("state_code", Configuration.ApiClient.ParameterToString(stateCode)); // query parameter
            if (vericredApiKey != null) localVarHeaderParams.Add("Vericred-Api-Key", Configuration.ApiClient.ParameterToString(vericredApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDrugCoverages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDrugCoverages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DrugCoverageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DrugCoverageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DrugCoverageResponse)));
            
        }

        /// <summary>
        /// Drug Search Search for drugs by proprietary name
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Full or partial proprietary name of drug</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>DrugSearchResponse</returns>
        public DrugSearchResponse ListDrugs (string searchTerm, string vericredApiKey = null)
        {
             ApiResponse<DrugSearchResponse> localVarResponse = ListDrugsWithHttpInfo(searchTerm, vericredApiKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Drug Search Search for drugs by proprietary name
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Full or partial proprietary name of drug</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>ApiResponse of DrugSearchResponse</returns>
        public ApiResponse< DrugSearchResponse > ListDrugsWithHttpInfo (string searchTerm, string vericredApiKey = null)
        {
            // verify the required parameter 'searchTerm' is set
            if (searchTerm == null)
                throw new ApiException(400, "Missing required parameter 'searchTerm' when calling DrugsApi->ListDrugs");

            var localVarPath = "/drugs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (searchTerm != null) localVarQueryParams.Add("search_term", Configuration.ApiClient.ParameterToString(searchTerm)); // query parameter
            if (vericredApiKey != null) localVarHeaderParams.Add("Vericred-Api-Key", Configuration.ApiClient.ParameterToString(vericredApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListDrugs: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListDrugs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DrugSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DrugSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DrugSearchResponse)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Full or partial proprietary name of drug</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of DrugSearchResponse</returns>
        public async System.Threading.Tasks.Task<DrugSearchResponse> ListDrugsAsync (string searchTerm, string vericredApiKey = null)
        {
             ApiResponse<DrugSearchResponse> localVarResponse = await ListDrugsAsyncWithHttpInfo(searchTerm, vericredApiKey);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">Full or partial proprietary name of drug</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of ApiResponse (DrugSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DrugSearchResponse>> ListDrugsAsyncWithHttpInfo (string searchTerm, string vericredApiKey = null)
        {
            // verify the required parameter 'searchTerm' is set
            if (searchTerm == null)
                throw new ApiException(400, "Missing required parameter 'searchTerm' when calling DrugsApi->ListDrugs");

            var localVarPath = "/drugs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (searchTerm != null) localVarQueryParams.Add("search_term", Configuration.ApiClient.ParameterToString(searchTerm)); // query parameter
            if (vericredApiKey != null) localVarHeaderParams.Add("Vericred-Api-Key", Configuration.ApiClient.ParameterToString(vericredApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListDrugs: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListDrugs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DrugSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DrugSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DrugSearchResponse)));
            
        }

    }
}
