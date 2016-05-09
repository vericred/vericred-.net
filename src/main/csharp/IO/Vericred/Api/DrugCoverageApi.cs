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
    public interface IDrugCoverageApi
    {
        #region Synchronous Operations

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndc">NDC for a drug</param>
        /// <returns>List&lt;DrugCoverage&gt;</returns>
        List<DrugCoverage> DrugsNdcCoveragesGet (string ndc);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndc">NDC for a drug</param>
        /// <returns>ApiResponse of List&lt;DrugCoverage&gt;</returns>
        ApiResponse<List<DrugCoverage>> DrugsNdcCoveragesGetWithHttpInfo (string ndc);
        #endregion Synchronous Operations
        #region Asynchronous Operations


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndc">NDC for a drug</param>
        /// <returns>Task of List&lt;DrugCoverage&gt;</returns>
        System.Threading.Tasks.Task<List<DrugCoverage>> DrugsNdcCoveragesGetAsync (string ndc);

        /// <summary>
        /// Find Drug Coverages for a given NDC
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndc">NDC for a drug</param>
        /// <returns>Task of ApiResponse (List&lt;DrugCoverage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DrugCoverage>>> DrugsNdcCoveragesGetAsyncWithHttpInfo (string ndc);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DrugCoverageApi : IDrugCoverageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrugCoverageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DrugCoverageApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrugCoverageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DrugCoverageApi(Configuration configuration = null)
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
        /// Find Drug Coverages for a given NDC Drug Coverages are the specific tier level, quantity limit, prior authorization and step therapy for a given Drug/Plan combination.  This endpoint returns all DrugCoverages for a given Drug  
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndc">NDC for a drug</param>
        /// <returns>List&lt;DrugCoverage&gt;</returns>
        public List<DrugCoverage> DrugsNdcCoveragesGet (string ndc)
        {
             ApiResponse<List<DrugCoverage>> localVarResponse = DrugsNdcCoveragesGetWithHttpInfo(ndc);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find Drug Coverages for a given NDC Drug Coverages are the specific tier level, quantity limit, prior authorization and step therapy for a given Drug/Plan combination.  This endpoint returns all DrugCoverages for a given Drug  
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndc">NDC for a drug</param>
        /// <returns>ApiResponse of List&lt;DrugCoverage&gt;</returns>
        public ApiResponse< List<DrugCoverage> > DrugsNdcCoveragesGetWithHttpInfo (string ndc)
        {
            // verify the required parameter 'ndc' is set
            if (ndc == null)
                throw new ApiException(400, "Missing required parameter 'ndc' when calling DrugCoverageApi->DrugsNdcCoveragesGet");

            var localVarPath = "/drugs/{ndc}/coverages";
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
            if (ndc != null) localVarPathParams.Add("ndc", Configuration.ApiClient.ParameterToString(ndc)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DrugsNdcCoveragesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DrugsNdcCoveragesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<DrugCoverage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DrugCoverage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DrugCoverage>)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndc">NDC for a drug</param>
        /// <returns>Task of List&lt;DrugCoverage&gt;</returns>
        public async System.Threading.Tasks.Task<List<DrugCoverage>> DrugsNdcCoveragesGetAsync (string ndc)
        {
             ApiResponse<List<DrugCoverage>> localVarResponse = await DrugsNdcCoveragesGetAsyncWithHttpInfo(ndc);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ndc">NDC for a drug</param>
        /// <returns>Task of ApiResponse (List&lt;DrugCoverage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DrugCoverage>>> DrugsNdcCoveragesGetAsyncWithHttpInfo (string ndc)
        {
            // verify the required parameter 'ndc' is set
            if (ndc == null)
                throw new ApiException(400, "Missing required parameter 'ndc' when calling DrugCoverageApi->DrugsNdcCoveragesGet");

            var localVarPath = "/drugs/{ndc}/coverages";
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
            if (ndc != null) localVarPathParams.Add("ndc", Configuration.ApiClient.ParameterToString(ndc)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DrugsNdcCoveragesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DrugsNdcCoveragesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<DrugCoverage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DrugCoverage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DrugCoverage>)));
            
        }

    }
}
