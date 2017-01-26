/* 
 * Vericred API
 *
 * Vericred's API allows you to search for Health Plans that a specific doctor
accepts.

## Getting Started

Visit our [Developer Portal](https://developers.vericred.com) to
create an account.

Once you have created an account, you can create one Application for
Production and another for our Sandbox (select the appropriate Plan when
you create the Application).

## SDKs

Our API follows standard REST conventions, so you can use any HTTP client
to integrate with us. You will likely find it easier to use one of our
[autogenerated SDKs](https://github.com/vericred/?query=vericred-),
which we make available for several common programming languages.

## Authentication

To authenticate, pass the API Key you created in the Developer Portal as
a `Vericred-Api-Key` header.

`curl -H 'Vericred-Api-Key: YOUR_KEY' "https://api.vericred.com/providers?search_term=Foo&zip_code=11215"`

## Versioning

Vericred's API default to the latest version.  However, if you need a specific
version, you can request it with an `Accept-Version` header.

The current version is `v3`.  Previous versions are `v1` and `v2`.

`curl -H 'Vericred-Api-Key: YOUR_KEY' -H 'Accept-Version: v2' "https://api.vericred.com/providers?search_term=Foo&zip_code=11215"`

## Pagination

Endpoints that accept `page` and `per_page` parameters are paginated. They expose
four additional fields that contain data about your position in the response,
namely `Total`, `Per-Page`, `Link`, and `Page` as described in [RFC-5988](https://tools.ietf.org/html/rfc5988).

For example, to display 5 results per page and view the second page of a
`GET` to `/networks`, your final request would be `GET /networks?....page=2&per_page=5`.

## Sideloading

When we return multiple levels of an object graph (e.g. `Provider`s and their `State`s
we sideload the associated data.  In this example, we would provide an Array of
`State`s and a `state_id` for each provider.  This is done primarily to reduce the
payload size since many of the `Provider`s will share a `State`

```
{
  providers: [{ id: 1, state_id: 1}, { id: 2, state_id: 1 }],
  states: [{ id: 1, code: 'NY' }]
}
```

If you need the second level of the object graph, you can just match the
corresponding id.

## Selecting specific data

All endpoints allow you to specify which fields you would like to return.
This allows you to limit the response to contain only the data you need.

For example, let's take a request that returns the following JSON by default

```
{
  provider: {
    id: 1,
    name: 'John',
    phone: '1234567890',
    field_we_dont_care_about: 'value_we_dont_care_about'
  },
  states: [{
    id: 1,
    name: 'New York',
    code: 'NY',
    field_we_dont_care_about: 'value_we_dont_care_about'
  }]
}
```

To limit our results to only return the fields we care about, we specify the
`select` query string parameter for the corresponding fields in the JSON
document.

In this case, we want to select `name` and `phone` from the `provider` key,
so we would add the parameters `select=provider.name,provider.phone`.
We also want the `name` and `code` from the `states` key, so we would
add the parameters `select=states.name,staes.code`.  The id field of
each document is always returned whether or not it is requested.

Our final request would be `GET /providers/12345?select=provider.name,provider.phone,states.name,states.code`

The response would be

```
{
  provider: {
    id: 1,
    name: 'John',
    phone: '1234567890'
  },
  states: [{
    id: 1,
    name: 'New York',
    code: 'NY'
  }]
}
```

## Benefits summary format
Benefit cost-share strings are formatted to capture:
 * Network tiers
 * Compound or conditional cost-share
 * Limits on the cost-share
 * Benefit-specific maximum out-of-pocket costs

**Example #1**
As an example, we would represent [this Summary of Benefits &amp; Coverage](https://s3.amazonaws.com/vericred-data/SBC/2017/33602TX0780032.pdf) as:

* **Hospital stay facility fees**:
  - Network Provider: `$400 copay/admit plus 20% coinsurance`
  - Out-of-Network Provider: `$1,500 copay/admit plus 50% coinsurance`
  - Vericred's format for this benefit: `In-Network: $400 before deductible then 20% after deductible / Out-of-Network: $1,500 before deductible then 50% after deductible`

* **Rehabilitation services:**
  - Network Provider: `20% coinsurance`
  - Out-of-Network Provider: `50% coinsurance`
  - Limitations & Exceptions: `35 visit maximum per benefit period combined with Chiropractic care.`
  - Vericred's format for this benefit: `In-Network: 20% after deductible / Out-of-Network: 50% after deductible | limit: 35 visit(s) per Benefit Period`

**Example #2**
In [this other Summary of Benefits &amp; Coverage](https://s3.amazonaws.com/vericred-data/SBC/2017/40733CA0110568.pdf), the **specialty_drugs** cost-share has a maximum out-of-pocket for in-network pharmacies.
* **Specialty drugs:**
  - Network Provider: `40% coinsurance up to a $500 maximum for up to a 30 day supply`
  - Out-of-Network Provider `Not covered`
  - Vericred's format for this benefit: `In-Network: 40% after deductible, up to $500 per script / Out-of-Network: 100%`

**BNF**

Here's a description of the benefits summary string, represented as a context-free grammar:

```
<cost-share>     ::= <tier> <opt-num-prefix> <value> <opt-per-unit> <deductible> <tier-limit> "/" <tier> <opt-num-prefix> <value> <opt-per-unit> <deductible> "|" <benefit-limit>
<tier>           ::= "In-Network:" | "In-Network-Tier-2:" | "Out-of-Network:"
<opt-num-prefix> ::= "first" <num> <unit> | ""
<unit>           ::= "day(s)" | "visit(s)" | "exam(s)" | "item(s)"
<value>          ::= <ddct_moop> | <copay> | <coinsurance> | <compound> | "unknown" | "Not Applicable"
<compound>       ::= <copay> <deductible> "then" <coinsurance> <deductible> | <copay> <deductible> "then" <copay> <deductible> | <coinsurance> <deductible> "then" <coinsurance> <deductible>
<copay>          ::= "$" <num>
<coinsurace>     ::= <num> "%"
<ddct_moop>      ::= <copay> | "Included in Medical" | "Unlimited"
<opt-per-unit>   ::= "per day" | "per visit" | "per stay" | ""
<deductible>     ::= "before deductible" | "after deductible" | ""
<tier-limit>     ::= ", " <limit> | ""
<benefit-limit>  ::= <limit> | ""
```


 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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
    public interface IDrugPackagesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Formulary Drug Package Search
        /// </summary>
        /// <remarks>
        /// Search for coverage by Formulary and DrugPackage ID
        /// </remarks>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formularyId">ID of the Formulary in question</param>
        /// <param name="ndcPackageCode">ID of the DrugPackage in question</param>
        /// <returns>FormularyDrugPackageResponse</returns>
        FormularyDrugPackageResponse ShowFormularyDrugPackageCoverage (string formularyId, string ndcPackageCode);

        /// <summary>
        /// Formulary Drug Package Search
        /// </summary>
        /// <remarks>
        /// Search for coverage by Formulary and DrugPackage ID
        /// </remarks>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formularyId">ID of the Formulary in question</param>
        /// <param name="ndcPackageCode">ID of the DrugPackage in question</param>
        /// <returns>ApiResponse of FormularyDrugPackageResponse</returns>
        ApiResponse<FormularyDrugPackageResponse> ShowFormularyDrugPackageCoverageWithHttpInfo (string formularyId, string ndcPackageCode);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Formulary Drug Package Search
        /// </summary>
        /// <remarks>
        /// Search for coverage by Formulary and DrugPackage ID
        /// </remarks>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formularyId">ID of the Formulary in question</param>
        /// <param name="ndcPackageCode">ID of the DrugPackage in question</param>
        /// <returns>Task of FormularyDrugPackageResponse</returns>
        System.Threading.Tasks.Task<FormularyDrugPackageResponse> ShowFormularyDrugPackageCoverageAsync (string formularyId, string ndcPackageCode);

        /// <summary>
        /// Formulary Drug Package Search
        /// </summary>
        /// <remarks>
        /// Search for coverage by Formulary and DrugPackage ID
        /// </remarks>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formularyId">ID of the Formulary in question</param>
        /// <param name="ndcPackageCode">ID of the DrugPackage in question</param>
        /// <returns>Task of ApiResponse (FormularyDrugPackageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormularyDrugPackageResponse>> ShowFormularyDrugPackageCoverageAsyncWithHttpInfo (string formularyId, string ndcPackageCode);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DrugPackagesApi : IDrugPackagesApi
    {
        private IO.Vericred.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrugPackagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DrugPackagesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Vericred.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrugPackagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DrugPackagesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Vericred.Client.Configuration.DefaultExceptionFactory;

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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Vericred.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

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
        /// Formulary Drug Package Search Search for coverage by Formulary and DrugPackage ID
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formularyId">ID of the Formulary in question</param>
        /// <param name="ndcPackageCode">ID of the DrugPackage in question</param>
        /// <returns>FormularyDrugPackageResponse</returns>
        public FormularyDrugPackageResponse ShowFormularyDrugPackageCoverage (string formularyId, string ndcPackageCode)
        {
             ApiResponse<FormularyDrugPackageResponse> localVarResponse = ShowFormularyDrugPackageCoverageWithHttpInfo(formularyId, ndcPackageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Formulary Drug Package Search Search for coverage by Formulary and DrugPackage ID
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formularyId">ID of the Formulary in question</param>
        /// <param name="ndcPackageCode">ID of the DrugPackage in question</param>
        /// <returns>ApiResponse of FormularyDrugPackageResponse</returns>
        public ApiResponse< FormularyDrugPackageResponse > ShowFormularyDrugPackageCoverageWithHttpInfo (string formularyId, string ndcPackageCode)
        {
            // verify the required parameter 'formularyId' is set
            if (formularyId == null)
                throw new ApiException(400, "Missing required parameter 'formularyId' when calling DrugPackagesApi->ShowFormularyDrugPackageCoverage");
            // verify the required parameter 'ndcPackageCode' is set
            if (ndcPackageCode == null)
                throw new ApiException(400, "Missing required parameter 'ndcPackageCode' when calling DrugPackagesApi->ShowFormularyDrugPackageCoverage");

            var localVarPath = "/formularies/{formulary_id}/drug_packages/{ndc_package_code}";
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
            if (formularyId != null) localVarPathParams.Add("formulary_id", Configuration.ApiClient.ParameterToString(formularyId)); // path parameter
            if (ndcPackageCode != null) localVarPathParams.Add("ndc_package_code", Configuration.ApiClient.ParameterToString(ndcPackageCode)); // path parameter

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

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowFormularyDrugPackageCoverage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FormularyDrugPackageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FormularyDrugPackageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FormularyDrugPackageResponse)));
            
        }

        /// <summary>
        /// Formulary Drug Package Search Search for coverage by Formulary and DrugPackage ID
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formularyId">ID of the Formulary in question</param>
        /// <param name="ndcPackageCode">ID of the DrugPackage in question</param>
        /// <returns>Task of FormularyDrugPackageResponse</returns>
        public async System.Threading.Tasks.Task<FormularyDrugPackageResponse> ShowFormularyDrugPackageCoverageAsync (string formularyId, string ndcPackageCode)
        {
             ApiResponse<FormularyDrugPackageResponse> localVarResponse = await ShowFormularyDrugPackageCoverageAsyncWithHttpInfo(formularyId, ndcPackageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Formulary Drug Package Search Search for coverage by Formulary and DrugPackage ID
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formularyId">ID of the Formulary in question</param>
        /// <param name="ndcPackageCode">ID of the DrugPackage in question</param>
        /// <returns>Task of ApiResponse (FormularyDrugPackageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormularyDrugPackageResponse>> ShowFormularyDrugPackageCoverageAsyncWithHttpInfo (string formularyId, string ndcPackageCode)
        {
            // verify the required parameter 'formularyId' is set
            if (formularyId == null)
                throw new ApiException(400, "Missing required parameter 'formularyId' when calling DrugPackagesApi->ShowFormularyDrugPackageCoverage");
            // verify the required parameter 'ndcPackageCode' is set
            if (ndcPackageCode == null)
                throw new ApiException(400, "Missing required parameter 'ndcPackageCode' when calling DrugPackagesApi->ShowFormularyDrugPackageCoverage");

            var localVarPath = "/formularies/{formulary_id}/drug_packages/{ndc_package_code}";
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
            if (formularyId != null) localVarPathParams.Add("formulary_id", Configuration.ApiClient.ParameterToString(formularyId)); // path parameter
            if (ndcPackageCode != null) localVarPathParams.Add("ndc_package_code", Configuration.ApiClient.ParameterToString(ndcPackageCode)); // path parameter

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

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowFormularyDrugPackageCoverage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FormularyDrugPackageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FormularyDrugPackageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FormularyDrugPackageResponse)));
            
        }

    }
}
