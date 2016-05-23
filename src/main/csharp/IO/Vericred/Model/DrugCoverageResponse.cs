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
    public partial class DrugCoverageResponse :  IEquatable<DrugCoverageResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DrugCoverageResponse" /> class.
        /// Initializes a new instance of the <see cref="DrugCoverageResponse" />class.
        /// </summary>
        /// <param name="Meta">Metadata for query.</param>
        /// <param name="DrugCoverages">DrugCoverage search results.</param>
        /// <param name="Drugs">Drug.</param>
        /// <param name="DrugPackages">Drug Packages.</param>

        public DrugCoverageResponse(Meta Meta = null, List<DrugCoverage> DrugCoverages = null, List<Drug> Drugs = null, List<DrugPackage> DrugPackages = null)
        {
            this.Meta = Meta;
            this.DrugCoverages = DrugCoverages;
            this.Drugs = Drugs;
            this.DrugPackages = DrugPackages;
            
        }

    
        /// <summary>
        /// Metadata for query
        /// </summary>
        /// <value>Metadata for query</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }
    
        /// <summary>
        /// DrugCoverage search results
        /// </summary>
        /// <value>DrugCoverage search results</value>
        [DataMember(Name="drug_coverages", EmitDefaultValue=false)]
        public List<DrugCoverage> DrugCoverages { get; set; }
    
        /// <summary>
        /// Drug
        /// </summary>
        /// <value>Drug</value>
        [DataMember(Name="drugs", EmitDefaultValue=false)]
        public List<Drug> Drugs { get; set; }
    
        /// <summary>
        /// Drug Packages
        /// </summary>
        /// <value>Drug Packages</value>
        [DataMember(Name="drug_packages", EmitDefaultValue=false)]
        public List<DrugPackage> DrugPackages { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrugCoverageResponse {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  DrugCoverages: ").Append(DrugCoverages).Append("\n");
            sb.Append("  Drugs: ").Append(Drugs).Append("\n");
            sb.Append("  DrugPackages: ").Append(DrugPackages).Append("\n");
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
            return this.Equals(obj as DrugCoverageResponse);
        }

        /// <summary>
        /// Returns true if DrugCoverageResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DrugCoverageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrugCoverageResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
                ) && 
                (
                    this.DrugCoverages == other.DrugCoverages ||
                    this.DrugCoverages != null &&
                    this.DrugCoverages.SequenceEqual(other.DrugCoverages)
                ) && 
                (
                    this.Drugs == other.Drugs ||
                    this.Drugs != null &&
                    this.Drugs.SequenceEqual(other.Drugs)
                ) && 
                (
                    this.DrugPackages == other.DrugPackages ||
                    this.DrugPackages != null &&
                    this.DrugPackages.SequenceEqual(other.DrugPackages)
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
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                if (this.DrugCoverages != null)
                    hash = hash * 59 + this.DrugCoverages.GetHashCode();
                if (this.Drugs != null)
                    hash = hash * 59 + this.Drugs.GetHashCode();
                if (this.DrugPackages != null)
                    hash = hash * 59 + this.DrugPackages.GetHashCode();
                return hash;
            }
        }

    }
}
