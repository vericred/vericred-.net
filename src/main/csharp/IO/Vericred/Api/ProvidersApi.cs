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
        /// <param name="npi">NPI number</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Provider</returns>
        Provider GetProvider (string npi, string vericredApiKey = null);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>ApiResponse of Provider</returns>
        ApiResponse<Provider> GetProviderWithHttpInfo (string npi, string vericredApiKey = null);

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ProvidersSearchResponse</returns>
        ProvidersSearchResponse GetProviders (RequestProvidersSearch body = null);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ProvidersSearchResponse</returns>
        ApiResponse<ProvidersSearchResponse> GetProvidersWithHttpInfo (RequestProvidersSearch body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of Provider</returns>
        System.Threading.Tasks.Task<Provider> GetProviderAsync (string npi, string vericredApiKey = null);

        /// <summary>
        /// Find a Provider
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of ApiResponse (Provider)</returns>
        System.Threading.Tasks.Task<ApiResponse<Provider>> GetProviderAsyncWithHttpInfo (string npi, string vericredApiKey = null);


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ProvidersSearchResponse</returns>
        System.Threading.Tasks.Task<ProvidersSearchResponse> GetProvidersAsync (RequestProvidersSearch body = null);

        /// <summary>
        /// Find Providers
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ProvidersSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProvidersSearchResponse>> GetProvidersAsyncWithHttpInfo (RequestProvidersSearch body = null);
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
        /// Find a Provider To retrieve a specific provider, just perform a GET using his NPI number
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Provider</returns>
        public Provider GetProvider (string npi, string vericredApiKey = null)
        {
             ApiResponse<Provider> localVarResponse = GetProviderWithHttpInfo(npi, vericredApiKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find a Provider To retrieve a specific provider, just perform a GET using his NPI number
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>ApiResponse of Provider</returns>
        public ApiResponse< Provider > GetProviderWithHttpInfo (string npi, string vericredApiKey = null)
        {
            // verify the required parameter 'npi' is set
            if (npi == null)
                throw new ApiException(400, "Missing required parameter 'npi' when calling ProvidersApi->GetProvider");

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
            if (vericredApiKey != null) localVarHeaderParams.Add("Vericred-Api-Key", Configuration.ApiClient.ParameterToString(vericredApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetProvider: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvider: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Provider>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Provider) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Provider)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of Provider</returns>
        public async System.Threading.Tasks.Task<Provider> GetProviderAsync (string npi, string vericredApiKey = null)
        {
             ApiResponse<Provider> localVarResponse = await GetProviderAsyncWithHttpInfo(npi, vericredApiKey);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="npi">NPI number</param>
        /// <param name="vericredApiKey">API Key (optional)</param>
        /// <returns>Task of ApiResponse (Provider)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Provider>> GetProviderAsyncWithHttpInfo (string npi, string vericredApiKey = null)
        {
            // verify the required parameter 'npi' is set
            if (npi == null)
                throw new ApiException(400, "Missing required parameter 'npi' when calling ProvidersApi->GetProvider");

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
            if (vericredApiKey != null) localVarHeaderParams.Add("Vericred-Api-Key", Configuration.ApiClient.ParameterToString(vericredApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetProvider: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvider: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Provider>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Provider) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Provider)));
            
        }

        /// <summary>
        /// Find Providers All &#x60;Provider&#x60; searches require a &#x60;zip_code&#x60;, which we use for weighting the search results to favor &#x60;Provider&#x60;s that are near the user.  For example, we would want &quot;Dr. John Smith&quot; who is 5 miles away to appear before &quot;Dr. John Smith&quot; who is 100 miles away.  The weighting also allows for non-exact matches.  In our prior example, we would want &quot;Dr. Jon Smith&quot; who is 2 miles away to appear before the exact match &quot;Dr. John Smith&quot; who is 100 miles away because it is more likely that the user just entered an incorrect name.  The free text search also supports Specialty name search and &quot;body part&quot; Specialty name search.  So, searching &quot;John Smith nose&quot; would return &quot;Dr. John Smith&quot;, the ENT Specialist before &quot;Dr. John Smith&quot; the Internist. 
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ProvidersSearchResponse</returns>
        public ProvidersSearchResponse GetProviders (RequestProvidersSearch body = null)
        {
             ApiResponse<ProvidersSearchResponse> localVarResponse = GetProvidersWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find Providers All &#x60;Provider&#x60; searches require a &#x60;zip_code&#x60;, which we use for weighting the search results to favor &#x60;Provider&#x60;s that are near the user.  For example, we would want &quot;Dr. John Smith&quot; who is 5 miles away to appear before &quot;Dr. John Smith&quot; who is 100 miles away.  The weighting also allows for non-exact matches.  In our prior example, we would want &quot;Dr. Jon Smith&quot; who is 2 miles away to appear before the exact match &quot;Dr. John Smith&quot; who is 100 miles away because it is more likely that the user just entered an incorrect name.  The free text search also supports Specialty name search and &quot;body part&quot; Specialty name search.  So, searching &quot;John Smith nose&quot; would return &quot;Dr. John Smith&quot;, the ENT Specialist before &quot;Dr. John Smith&quot; the Internist. 
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ProvidersSearchResponse</returns>
        public ApiResponse< ProvidersSearchResponse > GetProvidersWithHttpInfo (RequestProvidersSearch body = null)
        {

            var localVarPath = "/providers/search";
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
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetProviders: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProviders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProvidersSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProvidersSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProvidersSearchResponse)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ProvidersSearchResponse</returns>
        public async System.Threading.Tasks.Task<ProvidersSearchResponse> GetProvidersAsync (RequestProvidersSearch body = null)
        {
             ApiResponse<ProvidersSearchResponse> localVarResponse = await GetProvidersAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ProvidersSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProvidersSearchResponse>> GetProvidersAsyncWithHttpInfo (RequestProvidersSearch body = null)
        {

            var localVarPath = "/providers/search";
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
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetProviders: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProviders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProvidersSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProvidersSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProvidersSearchResponse)));
            
        }

    }
}
