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
    public interface INetworksApi
    {
        #region Synchronous Operations

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <returns>NetworkSearchResponse</returns>
        NetworkSearchResponse ListNetworks (string carrierId);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <returns>ApiResponse of NetworkSearchResponse</returns>
        ApiResponse<NetworkSearchResponse> ListNetworksWithHttpInfo (string carrierId);
        #endregion Synchronous Operations
        #region Asynchronous Operations


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <returns>Task of NetworkSearchResponse</returns>
        System.Threading.Tasks.Task<NetworkSearchResponse> ListNetworksAsync (string carrierId);

        /// <summary>
        /// Networks
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <returns>Task of ApiResponse (NetworkSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NetworkSearchResponse>> ListNetworksAsyncWithHttpInfo (string carrierId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NetworksApi : INetworksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NetworksApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NetworksApi(Configuration configuration = null)
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
        /// Networks A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members.
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <returns>NetworkSearchResponse</returns>
        public NetworkSearchResponse ListNetworks (string carrierId)
        {
             ApiResponse<NetworkSearchResponse> localVarResponse = ListNetworksWithHttpInfo(carrierId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Networks A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members.
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <returns>ApiResponse of NetworkSearchResponse</returns>
        public ApiResponse< NetworkSearchResponse > ListNetworksWithHttpInfo (string carrierId)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null)
                throw new ApiException(400, "Missing required parameter 'carrierId' when calling NetworksApi->ListNetworks");

            var localVarPath = "/networks";
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
            if (carrierId != null) localVarQueryParams.Add("carrier_id", Configuration.ApiClient.ParameterToString(carrierId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListNetworks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListNetworks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NetworkSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NetworkSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NetworkSearchResponse)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <returns>Task of NetworkSearchResponse</returns>
        public async System.Threading.Tasks.Task<NetworkSearchResponse> ListNetworksAsync (string carrierId)
        {
             ApiResponse<NetworkSearchResponse> localVarResponse = await ListNetworksAsyncWithHttpInfo(carrierId);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <returns>Task of ApiResponse (NetworkSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NetworkSearchResponse>> ListNetworksAsyncWithHttpInfo (string carrierId)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null)
                throw new ApiException(400, "Missing required parameter 'carrierId' when calling NetworksApi->ListNetworks");

            var localVarPath = "/networks";
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
            if (carrierId != null) localVarQueryParams.Add("carrier_id", Configuration.ApiClient.ParameterToString(carrierId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListNetworks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListNetworks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NetworkSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NetworkSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NetworkSearchResponse)));
            
        }

    }
}
