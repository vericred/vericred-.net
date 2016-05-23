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
    /// 
    /// </summary>
    [DataContract]
    public partial class RequestProvidersSearch :  IEquatable<RequestProvidersSearch>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestProvidersSearch" /> class.
        /// Initializes a new instance of the <see cref="RequestProvidersSearch" />class.
        /// </summary>
        /// <param name="AcceptsInsurance">Limit results to Providers who accept at least one insurance         plan.  Note that the inverse of this filter is not supported and         any value will evaluate to true.</param>
        /// <param name="HiosIds">List of HIOS ids.</param>
        /// <param name="Page">Page number.</param>
        /// <param name="PerPage">Number of records to return per page.</param>
        /// <param name="Radius">Radius (in miles) to use to limit results.</param>
        /// <param name="SearchTerm">String to search by.</param>
        /// <param name="ZipCode">Zip Code to search near.</param>
        /// <param name="Type">Either organization or individual.</param>

        public RequestProvidersSearch(bool? AcceptsInsurance = null, List<string> HiosIds = null, int? Page = null, int? PerPage = null, int? Radius = null, string SearchTerm = null, string ZipCode = null, string Type = null)
        {
            this.AcceptsInsurance = AcceptsInsurance;
            this.HiosIds = HiosIds;
            this.Page = Page;
            this.PerPage = PerPage;
            this.Radius = Radius;
            this.SearchTerm = SearchTerm;
            this.ZipCode = ZipCode;
            this.Type = Type;
            
        }

    
        /// <summary>
        /// Limit results to Providers who accept at least one insurance         plan.  Note that the inverse of this filter is not supported and         any value will evaluate to true
        /// </summary>
        /// <value>Limit results to Providers who accept at least one insurance         plan.  Note that the inverse of this filter is not supported and         any value will evaluate to true</value>
        [DataMember(Name="accepts_insurance", EmitDefaultValue=false)]
        public bool? AcceptsInsurance { get; set; }
    
        /// <summary>
        /// List of HIOS ids
        /// </summary>
        /// <value>List of HIOS ids</value>
        [DataMember(Name="hios_ids", EmitDefaultValue=false)]
        public List<string> HiosIds { get; set; }
    
        /// <summary>
        /// Page number
        /// </summary>
        /// <value>Page number</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
    
        /// <summary>
        /// Number of records to return per page
        /// </summary>
        /// <value>Number of records to return per page</value>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public int? PerPage { get; set; }
    
        /// <summary>
        /// Radius (in miles) to use to limit results
        /// </summary>
        /// <value>Radius (in miles) to use to limit results</value>
        [DataMember(Name="radius", EmitDefaultValue=false)]
        public int? Radius { get; set; }
    
        /// <summary>
        /// String to search by
        /// </summary>
        /// <value>String to search by</value>
        [DataMember(Name="search_term", EmitDefaultValue=false)]
        public string SearchTerm { get; set; }
    
        /// <summary>
        /// Zip Code to search near
        /// </summary>
        /// <value>Zip Code to search near</value>
        [DataMember(Name="zip_code", EmitDefaultValue=false)]
        public string ZipCode { get; set; }
    
        /// <summary>
        /// Either organization or individual
        /// </summary>
        /// <value>Either organization or individual</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestProvidersSearch {\n");
            sb.Append("  AcceptsInsurance: ").Append(AcceptsInsurance).Append("\n");
            sb.Append("  HiosIds: ").Append(HiosIds).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  Radius: ").Append(Radius).Append("\n");
            sb.Append("  SearchTerm: ").Append(SearchTerm).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as RequestProvidersSearch);
        }

        /// <summary>
        /// Returns true if RequestProvidersSearch instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestProvidersSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestProvidersSearch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcceptsInsurance == other.AcceptsInsurance ||
                    this.AcceptsInsurance != null &&
                    this.AcceptsInsurance.Equals(other.AcceptsInsurance)
                ) && 
                (
                    this.HiosIds == other.HiosIds ||
                    this.HiosIds != null &&
                    this.HiosIds.SequenceEqual(other.HiosIds)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.PerPage == other.PerPage ||
                    this.PerPage != null &&
                    this.PerPage.Equals(other.PerPage)
                ) && 
                (
                    this.Radius == other.Radius ||
                    this.Radius != null &&
                    this.Radius.Equals(other.Radius)
                ) && 
                (
                    this.SearchTerm == other.SearchTerm ||
                    this.SearchTerm != null &&
                    this.SearchTerm.Equals(other.SearchTerm)
                ) && 
                (
                    this.ZipCode == other.ZipCode ||
                    this.ZipCode != null &&
                    this.ZipCode.Equals(other.ZipCode)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.AcceptsInsurance != null)
                    hash = hash * 59 + this.AcceptsInsurance.GetHashCode();
                if (this.HiosIds != null)
                    hash = hash * 59 + this.HiosIds.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hash = hash * 59 + this.PerPage.GetHashCode();
                if (this.Radius != null)
                    hash = hash * 59 + this.Radius.GetHashCode();
                if (this.SearchTerm != null)
                    hash = hash * 59 + this.SearchTerm.GetHashCode();
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

    }
}
