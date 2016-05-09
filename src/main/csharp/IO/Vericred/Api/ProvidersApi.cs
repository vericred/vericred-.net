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
    public interface IProvidersApi
    {
        #region Synchronous Operations

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">String to search by</param>
        /// <param name="zipCode">Zip Code to search near</param>
        /// <param name="acceptsInsurance">Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true (optional)</param>
        /// <param name="hiosIds">HIOS id of one or more plans (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="perPage">Number of records to return per page (optional)</param>
        /// <param name="radius">Radius (in miles) to use to limit results (optional)</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 ProvidersGet (string searchTerm, string zipCode, string acceptsInsurance = null, List<string> hiosIds = null, string page = null, string perPage = null, string radius = null);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">String to search by</param>
        /// <param name="zipCode">Zip Code to search near</param>
        /// <param name="acceptsInsurance">Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true (optional)</param>
        /// <param name="hiosIds">HIOS id of one or more plans (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="perPage">Number of records to return per page (optional)</param>
        /// <param name="radius">Radius (in miles) to use to limit results (optional)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> ProvidersGetWithHttpInfo (string searchTerm, string zipCode, string acceptsInsurance = null, List<string> hiosIds = null, string page = null, string perPage = null, string radius = null);

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 ProvidersNpiGet (string npi);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> ProvidersNpiGetWithHttpInfo (string npi);
        #endregion Synchronous Operations
        #region Asynchronous Operations


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">String to search by</param>
        /// <param name="zipCode">Zip Code to search near</param>
        /// <param name="acceptsInsurance">Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true (optional)</param>
        /// <param name="hiosIds">HIOS id of one or more plans (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="perPage">Number of records to return per page (optional)</param>
        /// <param name="radius">Radius (in miles) to use to limit results (optional)</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> ProvidersGetAsync (string searchTerm, string zipCode, string acceptsInsurance = null, List<string> hiosIds = null, string page = null, string perPage = null, string radius = null);

        /// <summary>
        /// Find providers by term and zip code
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">String to search by</param>
        /// <param name="zipCode">Zip Code to search near</param>
        /// <param name="acceptsInsurance">Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true (optional)</param>
        /// <param name="hiosIds">HIOS id of one or more plans (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="perPage">Number of records to return per page (optional)</param>
        /// <param name="radius">Radius (in miles) to use to limit results (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> ProvidersGetAsyncWithHttpInfo (string searchTerm, string zipCode, string acceptsInsurance = null, List<string> hiosIds = null, string page = null, string perPage = null, string radius = null);


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> ProvidersNpiGetAsync (string npi);

        /// <summary>
        /// Find a specific Provider
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> ProvidersNpiGetAsyncWithHttpInfo (string npi);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProvidersApi : IProvidersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProvidersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProvidersApi(Configuration configuration = null)
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
        /// Find providers by term and zip code All &#x60;Provider&#x60; searches require a &#x60;zip_code&#x60;, which we use for weighting the search results to favor &#x60;Provider&#x60;s that are near the user.  For example, we would want &quot;Dr. John Smith&quot; who is 5 miles away to appear before &quot;Dr. John Smith&quot; who is 100 miles away.  The weighting also allows for non-exact matches.  In our prior example, we would want &quot;Dr. Jon Smith&quot; who is 2 miles away to appear before the exact match &quot;Dr. John Smith&quot; who is 100 miles away because it is more likely that the user just entered an incorrect name.  The free text search also supports Specialty name search and &quot;body part&quot; Specialty name search.  So, searching &quot;John Smith nose&quot; would return &quot;Dr. John Smith&quot;, the ENT Specialist before &quot;Dr. John Smith&quot; the Internist.  
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">String to search by</param>
        /// <param name="zipCode">Zip Code to search near</param>
        /// <param name="acceptsInsurance">Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true (optional)</param>
        /// <param name="hiosIds">HIOS id of one or more plans (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="perPage">Number of records to return per page (optional)</param>
        /// <param name="radius">Radius (in miles) to use to limit results (optional)</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 ProvidersGet (string searchTerm, string zipCode, string acceptsInsurance = null, List<string> hiosIds = null, string page = null, string perPage = null, string radius = null)
        {
             ApiResponse<InlineResponse200> localVarResponse = ProvidersGetWithHttpInfo(searchTerm, zipCode, acceptsInsurance, hiosIds, page, perPage, radius);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find providers by term and zip code All &#x60;Provider&#x60; searches require a &#x60;zip_code&#x60;, which we use for weighting the search results to favor &#x60;Provider&#x60;s that are near the user.  For example, we would want &quot;Dr. John Smith&quot; who is 5 miles away to appear before &quot;Dr. John Smith&quot; who is 100 miles away.  The weighting also allows for non-exact matches.  In our prior example, we would want &quot;Dr. Jon Smith&quot; who is 2 miles away to appear before the exact match &quot;Dr. John Smith&quot; who is 100 miles away because it is more likely that the user just entered an incorrect name.  The free text search also supports Specialty name search and &quot;body part&quot; Specialty name search.  So, searching &quot;John Smith nose&quot; would return &quot;Dr. John Smith&quot;, the ENT Specialist before &quot;Dr. John Smith&quot; the Internist.  
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">String to search by</param>
        /// <param name="zipCode">Zip Code to search near</param>
        /// <param name="acceptsInsurance">Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true (optional)</param>
        /// <param name="hiosIds">HIOS id of one or more plans (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="perPage">Number of records to return per page (optional)</param>
        /// <param name="radius">Radius (in miles) to use to limit results (optional)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > ProvidersGetWithHttpInfo (string searchTerm, string zipCode, string acceptsInsurance = null, List<string> hiosIds = null, string page = null, string perPage = null, string radius = null)
        {
            // verify the required parameter 'searchTerm' is set
            if (searchTerm == null)
                throw new ApiException(400, "Missing required parameter 'searchTerm' when calling ProvidersApi->ProvidersGet");
            // verify the required parameter 'zipCode' is set
            if (zipCode == null)
                throw new ApiException(400, "Missing required parameter 'zipCode' when calling ProvidersApi->ProvidersGet");

            var localVarPath = "/providers";
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
            if (acceptsInsurance != null) localVarQueryParams.Add("accepts_insurance", Configuration.ApiClient.ParameterToString(acceptsInsurance)); // query parameter
            if (hiosIds != null) localVarQueryParams.Add("hios_ids", Configuration.ApiClient.ParameterToString(hiosIds)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (radius != null) localVarQueryParams.Add("radius", Configuration.ApiClient.ParameterToString(radius)); // query parameter
            if (searchTerm != null) localVarQueryParams.Add("search_term", Configuration.ApiClient.ParameterToString(searchTerm)); // query parameter
            if (zipCode != null) localVarQueryParams.Add("zip_code", Configuration.ApiClient.ParameterToString(zipCode)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ProvidersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ProvidersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">String to search by</param>
        /// <param name="zipCode">Zip Code to search near</param>
        /// <param name="acceptsInsurance">Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true (optional)</param>
        /// <param name="hiosIds">HIOS id of one or more plans (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="perPage">Number of records to return per page (optional)</param>
        /// <param name="radius">Radius (in miles) to use to limit results (optional)</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> ProvidersGetAsync (string searchTerm, string zipCode, string acceptsInsurance = null, List<string> hiosIds = null, string page = null, string perPage = null, string radius = null)
        {
             ApiResponse<InlineResponse200> localVarResponse = await ProvidersGetAsyncWithHttpInfo(searchTerm, zipCode, acceptsInsurance, hiosIds, page, perPage, radius);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchTerm">String to search by</param>
        /// <param name="zipCode">Zip Code to search near</param>
        /// <param name="acceptsInsurance">Limit results to Providers who accept at least one insurance plan.  Note that the inverse of this filter is not supported and any value will evaluate to true (optional)</param>
        /// <param name="hiosIds">HIOS id of one or more plans (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="perPage">Number of records to return per page (optional)</param>
        /// <param name="radius">Radius (in miles) to use to limit results (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> ProvidersGetAsyncWithHttpInfo (string searchTerm, string zipCode, string acceptsInsurance = null, List<string> hiosIds = null, string page = null, string perPage = null, string radius = null)
        {
            // verify the required parameter 'searchTerm' is set
            if (searchTerm == null)
                throw new ApiException(400, "Missing required parameter 'searchTerm' when calling ProvidersApi->ProvidersGet");
            // verify the required parameter 'zipCode' is set
            if (zipCode == null)
                throw new ApiException(400, "Missing required parameter 'zipCode' when calling ProvidersApi->ProvidersGet");

            var localVarPath = "/providers";
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
            if (acceptsInsurance != null) localVarQueryParams.Add("accepts_insurance", Configuration.ApiClient.ParameterToString(acceptsInsurance)); // query parameter
            if (hiosIds != null) localVarQueryParams.Add("hios_ids", Configuration.ApiClient.ParameterToString(hiosIds)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (radius != null) localVarQueryParams.Add("radius", Configuration.ApiClient.ParameterToString(radius)); // query parameter
            if (searchTerm != null) localVarQueryParams.Add("search_term", Configuration.ApiClient.ParameterToString(searchTerm)); // query parameter
            if (zipCode != null) localVarQueryParams.Add("zip_code", Configuration.ApiClient.ParameterToString(zipCode)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ProvidersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ProvidersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Find a specific Provider To retrieve a specific provider, just perform a GET using his NPI number  
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 ProvidersNpiGet (string npi)
        {
             ApiResponse<InlineResponse2001> localVarResponse = ProvidersNpiGetWithHttpInfo(npi);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find a specific Provider To retrieve a specific provider, just perform a GET using his NPI number  
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > ProvidersNpiGetWithHttpInfo (string npi)
        {
            // verify the required parameter 'npi' is set
            if (npi == null)
                throw new ApiException(400, "Missing required parameter 'npi' when calling ProvidersApi->ProvidersNpiGet");

            var localVarPath = "/providers/{npi}";
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
            if (npi != null) localVarPathParams.Add("npi", Configuration.ApiClient.ParameterToString(npi)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ProvidersNpiGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ProvidersNpiGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> ProvidersNpiGetAsync (string npi)
        {
             ApiResponse<InlineResponse2001> localVarResponse = await ProvidersNpiGetAsyncWithHttpInfo(npi);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> ProvidersNpiGetAsyncWithHttpInfo (string npi)
        {
            // verify the required parameter 'npi' is set
            if (npi == null)
                throw new ApiException(400, "Missing required parameter 'npi' when calling ProvidersApi->ProvidersNpiGet");

            var localVarPath = "/providers/{npi}";
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
            if (npi != null) localVarPathParams.Add("npi", Configuration.ApiClient.ParameterToString(npi)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ProvidersNpiGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ProvidersNpiGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
            
        }

    }
}
