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
    public interface IZipCountiesApi
    {
        #region Synchronous Operations

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zipPrefix">Partial five-digit Zip</param>
        /// <returns>ZipCountyResponse</returns>
        ZipCountyResponse GetZipCounties (string zipPrefix);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zipPrefix">Partial five-digit Zip</param>
        /// <returns>ApiResponse of ZipCountyResponse</returns>
        ApiResponse<ZipCountyResponse> GetZipCountiesWithHttpInfo (string zipPrefix);
        #endregion Synchronous Operations
        #region Asynchronous Operations


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zipPrefix">Partial five-digit Zip</param>
        /// <returns>Task of ZipCountyResponse</returns>
        System.Threading.Tasks.Task<ZipCountyResponse> GetZipCountiesAsync (string zipPrefix);

        /// <summary>
        /// Search for Zip Counties
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zipPrefix">Partial five-digit Zip</param>
        /// <returns>Task of ApiResponse (ZipCountyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ZipCountyResponse>> GetZipCountiesAsyncWithHttpInfo (string zipPrefix);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ZipCountiesApi : IZipCountiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipCountiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZipCountiesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipCountiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZipCountiesApi(Configuration configuration = null)
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
        /// Search for Zip Counties Our &#x60;Plan&#x60; endpoints require a zip code and a fips (county) code.  This is because plan pricing requires both of these elements.  Users are unlikely to know their fips code, so we provide this endpoint to look up a &#x60;ZipCounty&#x60; by zip code and return both the selected zip and fips codes.
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zipPrefix">Partial five-digit Zip</param>
        /// <returns>ZipCountyResponse</returns>
        public ZipCountyResponse GetZipCounties (string zipPrefix)
        {
             ApiResponse<ZipCountyResponse> localVarResponse = GetZipCountiesWithHttpInfo(zipPrefix);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for Zip Counties Our &#x60;Plan&#x60; endpoints require a zip code and a fips (county) code.  This is because plan pricing requires both of these elements.  Users are unlikely to know their fips code, so we provide this endpoint to look up a &#x60;ZipCounty&#x60; by zip code and return both the selected zip and fips codes.
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zipPrefix">Partial five-digit Zip</param>
        /// <returns>ApiResponse of ZipCountyResponse</returns>
        public ApiResponse< ZipCountyResponse > GetZipCountiesWithHttpInfo (string zipPrefix)
        {
            // verify the required parameter 'zipPrefix' is set
            if (zipPrefix == null)
                throw new ApiException(400, "Missing required parameter 'zipPrefix' when calling ZipCountiesApi->GetZipCounties");

            var localVarPath = "/zip_counties";
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
            if (zipPrefix != null) localVarQueryParams.Add("zip_prefix", Configuration.ApiClient.ParameterToString(zipPrefix)); // query parameter

            // authentication (Vericred-Api-Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Vericred-Api-Key")))
            {
                localVarHeaderParams["Vericred-Api-Key"] = Configuration.GetApiKeyWithPrefix("Vericred-Api-Key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetZipCounties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetZipCounties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ZipCountyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ZipCountyResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ZipCountyResponse)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zipPrefix">Partial five-digit Zip</param>
        /// <returns>Task of ZipCountyResponse</returns>
        public async System.Threading.Tasks.Task<ZipCountyResponse> GetZipCountiesAsync (string zipPrefix)
        {
             ApiResponse<ZipCountyResponse> localVarResponse = await GetZipCountiesAsyncWithHttpInfo(zipPrefix);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zipPrefix">Partial five-digit Zip</param>
        /// <returns>Task of ApiResponse (ZipCountyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ZipCountyResponse>> GetZipCountiesAsyncWithHttpInfo (string zipPrefix)
        {
            // verify the required parameter 'zipPrefix' is set
            if (zipPrefix == null)
                throw new ApiException(400, "Missing required parameter 'zipPrefix' when calling ZipCountiesApi->GetZipCounties");

            var localVarPath = "/zip_counties";
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
            if (zipPrefix != null) localVarQueryParams.Add("zip_prefix", Configuration.ApiClient.ParameterToString(zipPrefix)); // query parameter

            // authentication (Vericred-Api-Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Vericred-Api-Key")))
            {
                localVarHeaderParams["Vericred-Api-Key"] = Configuration.GetApiKeyWithPrefix("Vericred-Api-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetZipCounties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetZipCounties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ZipCountyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ZipCountyResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ZipCountyResponse)));
            
        }

    }
}
