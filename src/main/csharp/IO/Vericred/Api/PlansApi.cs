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
    public interface IPlansApi
    {
        #region Synchronous Operations

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PlanSearchResponse</returns>
        PlanSearchResponse FindPlans (RequestPlanFind body = null);



        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PlanSearchResponse</returns>
        ApiResponse<PlanSearchResponse> FindPlansWithHttpInfo (RequestPlanFind body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PlanSearchResponse</returns>
        System.Threading.Tasks.Task<PlanSearchResponse> FindPlansAsync (RequestPlanFind body = null);

        /// <summary>
        /// Find Plans
        /// </summary>

        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PlanSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlanSearchResponse>> FindPlansAsyncWithHttpInfo (RequestPlanFind body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PlansApi : IPlansApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlansApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlansApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlansApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PlansApi(Configuration configuration = null)
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
        /// Find Plans ### Location Information  Searching for a set of plans requires a &#x60;zip_code&#x60; and &#x60;fips_code&#x60; code.  These are used to determine pricing and availabity of health plans.  Optionally, you may provide a list of Applicants or Providers  ### Applicants  This is a list of people who will be covered by the plan.  We use this list to calculate the premium.  You must include &#x60;age&#x60; and can include &#x60;smoker&#x60;, which also factors into pricing in some states.  Applicants *must* include an age.  If smoker is omitted, its value is assumed to be false.  #### Multiple Applicants To get pricing for multiple applicants, just append multiple sets of data to the URL with the age and smoking status of each applicant next to each other.  For example, given two applicants - one age 32 and a non-smoker and one age 29 and a smoker, you could use the following request  &#x60;GET /plans?zip_code&#x3D;07451&amp;fips_code&#x3D;33025&amp;applicants[][age]&#x3D;32&amp;applicants[][age]&#x3D;29&amp;applicants[][smoker]&#x3D;true&#x60;  It would also be acceptible to include &#x60;applicants[][smoker]&#x3D;false&#x60; after the first applicant&#39;s age.  ### Providers  We identify Providers (Doctors) by their National Practitioner Index number (NPI).  If you pass a list of Providers, keyed by their NPI number, we will return a list of which Providers are in and out of network for each plan returned.  For example, if we had two providers with the NPI numbers &#x60;12345&#x60; and &#x60;23456&#x60; you would make the following request  &#x60;GET /plans?zip_code&#x3D;07451&amp;fips_code&#x3D;33025&amp;providers[][npi]&#x3D;12345&amp;providers[][npi]&#x3D;23456&#x60;  ### Enrollment Date  To calculate plan pricing and availability, we default to the current date as the enrollment date.  To specify a date in the future (or the past), pass a string with the format &#x60;YYYY-MM-DD&#x60; in the &#x60;enrollment_date&#x60; parameter.  &#x60;GET /plans?zip_code&#x3D;07451&amp;fips_code&#x3D;33025&amp;enrollment_date&#x3D;2016-01-01&#x60;  ### Subsidy  On-marketplace plans are eligible for a subsidy based on the &#x60;household_size&#x60; and &#x60;household_income&#x60; of the applicants.  If you pass those values, we will calculate the &#x60;subsidized_premium&#x60; and return it for each plan.  If no values are provided, the &#x60;subsidized_premium&#x60; will be the same as the &#x60;premium&#x60;  &#x60;GET /plans?zip_code&#x3D;07451&amp;fips_code&#x3D;33025&amp;household_size&#x3D;4&amp;household_income&#x3D;40000&#x60; 
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PlanSearchResponse</returns>
        public PlanSearchResponse FindPlans (RequestPlanFind body = null)
        {
             ApiResponse<PlanSearchResponse> localVarResponse = FindPlansWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find Plans ### Location Information  Searching for a set of plans requires a &#x60;zip_code&#x60; and &#x60;fips_code&#x60; code.  These are used to determine pricing and availabity of health plans.  Optionally, you may provide a list of Applicants or Providers  ### Applicants  This is a list of people who will be covered by the plan.  We use this list to calculate the premium.  You must include &#x60;age&#x60; and can include &#x60;smoker&#x60;, which also factors into pricing in some states.  Applicants *must* include an age.  If smoker is omitted, its value is assumed to be false.  #### Multiple Applicants To get pricing for multiple applicants, just append multiple sets of data to the URL with the age and smoking status of each applicant next to each other.  For example, given two applicants - one age 32 and a non-smoker and one age 29 and a smoker, you could use the following request  &#x60;GET /plans?zip_code&#x3D;07451&amp;fips_code&#x3D;33025&amp;applicants[][age]&#x3D;32&amp;applicants[][age]&#x3D;29&amp;applicants[][smoker]&#x3D;true&#x60;  It would also be acceptible to include &#x60;applicants[][smoker]&#x3D;false&#x60; after the first applicant&#39;s age.  ### Providers  We identify Providers (Doctors) by their National Practitioner Index number (NPI).  If you pass a list of Providers, keyed by their NPI number, we will return a list of which Providers are in and out of network for each plan returned.  For example, if we had two providers with the NPI numbers &#x60;12345&#x60; and &#x60;23456&#x60; you would make the following request  &#x60;GET /plans?zip_code&#x3D;07451&amp;fips_code&#x3D;33025&amp;providers[][npi]&#x3D;12345&amp;providers[][npi]&#x3D;23456&#x60;  ### Enrollment Date  To calculate plan pricing and availability, we default to the current date as the enrollment date.  To specify a date in the future (or the past), pass a string with the format &#x60;YYYY-MM-DD&#x60; in the &#x60;enrollment_date&#x60; parameter.  &#x60;GET /plans?zip_code&#x3D;07451&amp;fips_code&#x3D;33025&amp;enrollment_date&#x3D;2016-01-01&#x60;  ### Subsidy  On-marketplace plans are eligible for a subsidy based on the &#x60;household_size&#x60; and &#x60;household_income&#x60; of the applicants.  If you pass those values, we will calculate the &#x60;subsidized_premium&#x60; and return it for each plan.  If no values are provided, the &#x60;subsidized_premium&#x60; will be the same as the &#x60;premium&#x60;  &#x60;GET /plans?zip_code&#x3D;07451&amp;fips_code&#x3D;33025&amp;household_size&#x3D;4&amp;household_income&#x3D;40000&#x60; 
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PlanSearchResponse</returns>
        public ApiResponse< PlanSearchResponse > FindPlansWithHttpInfo (RequestPlanFind body = null)
        {

            var localVarPath = "/plans/search";
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
                throw new ApiException (localVarStatusCode, "Error calling FindPlans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindPlans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlanSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanSearchResponse)));
            
        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PlanSearchResponse</returns>
        public async System.Threading.Tasks.Task<PlanSearchResponse> FindPlansAsync (RequestPlanFind body = null)
        {
             ApiResponse<PlanSearchResponse> localVarResponse = await FindPlansAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }


        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PlanSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlanSearchResponse>> FindPlansAsyncWithHttpInfo (RequestPlanFind body = null)
        {

            var localVarPath = "/plans/search";
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
                throw new ApiException (localVarStatusCode, "Error calling FindPlans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindPlans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlanSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanSearchResponse)));
            
        }

    }
}
