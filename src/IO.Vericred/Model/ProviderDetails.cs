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
    /// ProviderDetails
    /// </summary>
    [DataContract]
    public partial class ProviderDetails :  IEquatable<ProviderDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderDetails" /> class.
        /// </summary>
        /// <param name="City">City name (e.g. Springfield)..</param>
        /// <param name="Email">Primary email address to contact the provider..</param>
        /// <param name="Gender">Provider&#39;s gender (M or F).</param>
        /// <param name="FirstName">Given name for the provider..</param>
        /// <param name="Id">National Provider Index (NPI) number.</param>
        /// <param name="LastName">Family name for the provider..</param>
        /// <param name="Latitude">Latitude of provider.</param>
        /// <param name="Longitude">Longitude of provider.</param>
        /// <param name="MiddleName">Middle name for the provider..</param>
        /// <param name="NetworkIds">Array of network ids.</param>
        /// <param name="OrganizationName">name for the providers of type: organization..</param>
        /// <param name="PersonalPhone">Personal contact phone for the provider..</param>
        /// <param name="Phone">Office phone for the provider.</param>
        /// <param name="PresentationName">Preferred name for display (e.g. Dr. Francis White may prefer Dr. Frank White).</param>
        /// <param name="Specialty">Name of the primary Specialty.</param>
        /// <param name="State">State code for the provider&#39;s address (e.g. NY)..</param>
        /// <param name="StateId">Foreign key to States.</param>
        /// <param name="StreetLine1">First line of the provider&#39;s street address..</param>
        /// <param name="StreetLine2">Second line of the provider&#39;s street address..</param>
        /// <param name="Suffix">Suffix for the provider&#39;s name (e.g. Jr).</param>
        /// <param name="Title">Professional title for the provider (e.g. Dr)..</param>
        /// <param name="Type">Type of NPI number (individual provider vs organization)..</param>
        /// <param name="ZipCode">Postal code for the provider&#39;s address (e.g. 11215).</param>
        /// <param name="HiosIds">List of HIOS ids for this provider.</param>
        public ProviderDetails(string City = null, string Email = null, string Gender = null, string FirstName = null, int? Id = null, string LastName = null, decimal? Latitude = null, decimal? Longitude = null, string MiddleName = null, List<int?> NetworkIds = null, string OrganizationName = null, string PersonalPhone = null, string Phone = null, string PresentationName = null, string Specialty = null, string State = null, int? StateId = null, string StreetLine1 = null, string StreetLine2 = null, string Suffix = null, string Title = null, string Type = null, string ZipCode = null, List<string> HiosIds = null)
        {
            this.City = City;
            this.Email = Email;
            this.Gender = Gender;
            this.FirstName = FirstName;
            this.Id = Id;
            this.LastName = LastName;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.MiddleName = MiddleName;
            this.NetworkIds = NetworkIds;
            this.OrganizationName = OrganizationName;
            this.PersonalPhone = PersonalPhone;
            this.Phone = Phone;
            this.PresentationName = PresentationName;
            this.Specialty = Specialty;
            this.State = State;
            this.StateId = StateId;
            this.StreetLine1 = StreetLine1;
            this.StreetLine2 = StreetLine2;
            this.Suffix = Suffix;
            this.Title = Title;
            this.Type = Type;
            this.ZipCode = ZipCode;
            this.HiosIds = HiosIds;
        }
        
        /// <summary>
        /// City name (e.g. Springfield).
        /// </summary>
        /// <value>City name (e.g. Springfield).</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Primary email address to contact the provider.
        /// </summary>
        /// <value>Primary email address to contact the provider.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Provider&#39;s gender (M or F)
        /// </summary>
        /// <value>Provider&#39;s gender (M or F)</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
        /// <summary>
        /// Given name for the provider.
        /// </summary>
        /// <value>Given name for the provider.</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// National Provider Index (NPI) number
        /// </summary>
        /// <value>National Provider Index (NPI) number</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Family name for the provider.
        /// </summary>
        /// <value>Family name for the provider.</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Latitude of provider
        /// </summary>
        /// <value>Latitude of provider</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public decimal? Latitude { get; set; }
        /// <summary>
        /// Longitude of provider
        /// </summary>
        /// <value>Longitude of provider</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public decimal? Longitude { get; set; }
        /// <summary>
        /// Middle name for the provider.
        /// </summary>
        /// <value>Middle name for the provider.</value>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }
        /// <summary>
        /// Array of network ids
        /// </summary>
        /// <value>Array of network ids</value>
        [DataMember(Name="network_ids", EmitDefaultValue=false)]
        public List<int?> NetworkIds { get; set; }
        /// <summary>
        /// name for the providers of type: organization.
        /// </summary>
        /// <value>name for the providers of type: organization.</value>
        [DataMember(Name="organization_name", EmitDefaultValue=false)]
        public string OrganizationName { get; set; }
        /// <summary>
        /// Personal contact phone for the provider.
        /// </summary>
        /// <value>Personal contact phone for the provider.</value>
        [DataMember(Name="personal_phone", EmitDefaultValue=false)]
        public string PersonalPhone { get; set; }
        /// <summary>
        /// Office phone for the provider
        /// </summary>
        /// <value>Office phone for the provider</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Preferred name for display (e.g. Dr. Francis White may prefer Dr. Frank White)
        /// </summary>
        /// <value>Preferred name for display (e.g. Dr. Francis White may prefer Dr. Frank White)</value>
        [DataMember(Name="presentation_name", EmitDefaultValue=false)]
        public string PresentationName { get; set; }
        /// <summary>
        /// Name of the primary Specialty
        /// </summary>
        /// <value>Name of the primary Specialty</value>
        [DataMember(Name="specialty", EmitDefaultValue=false)]
        public string Specialty { get; set; }
        /// <summary>
        /// State code for the provider&#39;s address (e.g. NY).
        /// </summary>
        /// <value>State code for the provider&#39;s address (e.g. NY).</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Foreign key to States
        /// </summary>
        /// <value>Foreign key to States</value>
        [DataMember(Name="state_id", EmitDefaultValue=false)]
        public int? StateId { get; set; }
        /// <summary>
        /// First line of the provider&#39;s street address.
        /// </summary>
        /// <value>First line of the provider&#39;s street address.</value>
        [DataMember(Name="street_line_1", EmitDefaultValue=false)]
        public string StreetLine1 { get; set; }
        /// <summary>
        /// Second line of the provider&#39;s street address.
        /// </summary>
        /// <value>Second line of the provider&#39;s street address.</value>
        [DataMember(Name="street_line_2", EmitDefaultValue=false)]
        public string StreetLine2 { get; set; }
        /// <summary>
        /// Suffix for the provider&#39;s name (e.g. Jr)
        /// </summary>
        /// <value>Suffix for the provider&#39;s name (e.g. Jr)</value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }
        /// <summary>
        /// Professional title for the provider (e.g. Dr).
        /// </summary>
        /// <value>Professional title for the provider (e.g. Dr).</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Type of NPI number (individual provider vs organization).
        /// </summary>
        /// <value>Type of NPI number (individual provider vs organization).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Postal code for the provider&#39;s address (e.g. 11215)
        /// </summary>
        /// <value>Postal code for the provider&#39;s address (e.g. 11215)</value>
        [DataMember(Name="zip_code", EmitDefaultValue=false)]
        public string ZipCode { get; set; }
        /// <summary>
        /// List of HIOS ids for this provider
        /// </summary>
        /// <value>List of HIOS ids for this provider</value>
        [DataMember(Name="hios_ids", EmitDefaultValue=false)]
        public List<string> HiosIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProviderDetails {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  NetworkIds: ").Append(NetworkIds).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  PersonalPhone: ").Append(PersonalPhone).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PresentationName: ").Append(PresentationName).Append("\n");
            sb.Append("  Specialty: ").Append(Specialty).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  StreetLine1: ").Append(StreetLine1).Append("\n");
            sb.Append("  StreetLine2: ").Append(StreetLine2).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  HiosIds: ").Append(HiosIds).Append("\n");
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
            return this.Equals(obj as ProviderDetails);
        }

        /// <summary>
        /// Returns true if ProviderDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ProviderDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProviderDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.NetworkIds == other.NetworkIds ||
                    this.NetworkIds != null &&
                    this.NetworkIds.SequenceEqual(other.NetworkIds)
                ) && 
                (
                    this.OrganizationName == other.OrganizationName ||
                    this.OrganizationName != null &&
                    this.OrganizationName.Equals(other.OrganizationName)
                ) && 
                (
                    this.PersonalPhone == other.PersonalPhone ||
                    this.PersonalPhone != null &&
                    this.PersonalPhone.Equals(other.PersonalPhone)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.PresentationName == other.PresentationName ||
                    this.PresentationName != null &&
                    this.PresentationName.Equals(other.PresentationName)
                ) && 
                (
                    this.Specialty == other.Specialty ||
                    this.Specialty != null &&
                    this.Specialty.Equals(other.Specialty)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.StateId == other.StateId ||
                    this.StateId != null &&
                    this.StateId.Equals(other.StateId)
                ) && 
                (
                    this.StreetLine1 == other.StreetLine1 ||
                    this.StreetLine1 != null &&
                    this.StreetLine1.Equals(other.StreetLine1)
                ) && 
                (
                    this.StreetLine2 == other.StreetLine2 ||
                    this.StreetLine2 != null &&
                    this.StreetLine2.Equals(other.StreetLine2)
                ) && 
                (
                    this.Suffix == other.Suffix ||
                    this.Suffix != null &&
                    this.Suffix.Equals(other.Suffix)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ZipCode == other.ZipCode ||
                    this.ZipCode != null &&
                    this.ZipCode.Equals(other.ZipCode)
                ) && 
                (
                    this.HiosIds == other.HiosIds ||
                    this.HiosIds != null &&
                    this.HiosIds.SequenceEqual(other.HiosIds)
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
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                if (this.NetworkIds != null)
                    hash = hash * 59 + this.NetworkIds.GetHashCode();
                if (this.OrganizationName != null)
                    hash = hash * 59 + this.OrganizationName.GetHashCode();
                if (this.PersonalPhone != null)
                    hash = hash * 59 + this.PersonalPhone.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.PresentationName != null)
                    hash = hash * 59 + this.PresentationName.GetHashCode();
                if (this.Specialty != null)
                    hash = hash * 59 + this.Specialty.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.StateId != null)
                    hash = hash * 59 + this.StateId.GetHashCode();
                if (this.StreetLine1 != null)
                    hash = hash * 59 + this.StreetLine1.GetHashCode();
                if (this.StreetLine2 != null)
                    hash = hash * 59 + this.StreetLine2.GetHashCode();
                if (this.Suffix != null)
                    hash = hash * 59 + this.Suffix.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                if (this.HiosIds != null)
                    hash = hash * 59 + this.HiosIds.GetHashCode();
                return hash;
            }
        }
    }

}
