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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Vericred.Model
{
    /// <summary>
    /// Drug
    /// </summary>
    [DataContract]
    public partial class Drug :  IEquatable<Drug>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drug" /> class.
        /// </summary>
        /// <param name="Id">National Drug Code ID.</param>
        /// <param name="ActiveIngredientStrength">Active Ingredient Strength information.</param>
        /// <param name="ProprietaryName">Proprietary name of drug.</param>
        /// <param name="NonProprietaryName">Non-proprietary name of drug.</param>
        /// <param name="DrugPackageIds">Array of drug package Ids.</param>
        public Drug(string Id = null, string ActiveIngredientStrength = null, string ProprietaryName = null, string NonProprietaryName = null, List<string> DrugPackageIds = null)
        {
            this.Id = Id;
            this.ActiveIngredientStrength = ActiveIngredientStrength;
            this.ProprietaryName = ProprietaryName;
            this.NonProprietaryName = NonProprietaryName;
            this.DrugPackageIds = DrugPackageIds;
        }
        
        /// <summary>
        /// National Drug Code ID
        /// </summary>
        /// <value>National Drug Code ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Active Ingredient Strength information
        /// </summary>
        /// <value>Active Ingredient Strength information</value>
        [DataMember(Name="active_ingredient_strength", EmitDefaultValue=false)]
        public string ActiveIngredientStrength { get; set; }
        /// <summary>
        /// Proprietary name of drug
        /// </summary>
        /// <value>Proprietary name of drug</value>
        [DataMember(Name="proprietary_name", EmitDefaultValue=false)]
        public string ProprietaryName { get; set; }
        /// <summary>
        /// Non-proprietary name of drug
        /// </summary>
        /// <value>Non-proprietary name of drug</value>
        [DataMember(Name="non_proprietary_name", EmitDefaultValue=false)]
        public string NonProprietaryName { get; set; }
        /// <summary>
        /// Array of drug package Ids
        /// </summary>
        /// <value>Array of drug package Ids</value>
        [DataMember(Name="drug_package_ids", EmitDefaultValue=false)]
        public List<string> DrugPackageIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Drug {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActiveIngredientStrength: ").Append(ActiveIngredientStrength).Append("\n");
            sb.Append("  ProprietaryName: ").Append(ProprietaryName).Append("\n");
            sb.Append("  NonProprietaryName: ").Append(NonProprietaryName).Append("\n");
            sb.Append("  DrugPackageIds: ").Append(DrugPackageIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Drug);
        }

        /// <summary>
        /// Returns true if Drug instances are equal
        /// </summary>
        /// <param name="other">Instance of Drug to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Drug other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ActiveIngredientStrength == other.ActiveIngredientStrength ||
                    this.ActiveIngredientStrength != null &&
                    this.ActiveIngredientStrength.Equals(other.ActiveIngredientStrength)
                ) && 
                (
                    this.ProprietaryName == other.ProprietaryName ||
                    this.ProprietaryName != null &&
                    this.ProprietaryName.Equals(other.ProprietaryName)
                ) && 
                (
                    this.NonProprietaryName == other.NonProprietaryName ||
                    this.NonProprietaryName != null &&
                    this.NonProprietaryName.Equals(other.NonProprietaryName)
                ) && 
                (
                    this.DrugPackageIds == other.DrugPackageIds ||
                    this.DrugPackageIds != null &&
                    this.DrugPackageIds.SequenceEqual(other.DrugPackageIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ActiveIngredientStrength != null)
                    hash = hash * 59 + this.ActiveIngredientStrength.GetHashCode();
                if (this.ProprietaryName != null)
                    hash = hash * 59 + this.ProprietaryName.GetHashCode();
                if (this.NonProprietaryName != null)
                    hash = hash * 59 + this.NonProprietaryName.GetHashCode();
                if (this.DrugPackageIds != null)
                    hash = hash * 59 + this.DrugPackageIds.GetHashCode();
                return hash;
            }
        }
    }

}
