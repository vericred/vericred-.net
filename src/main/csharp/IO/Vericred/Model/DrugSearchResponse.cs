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
    public partial class DrugSearchResponse :  IEquatable<DrugSearchResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DrugSearchResponse" /> class.
        /// Initializes a new instance of the <see cref="DrugSearchResponse" />class.
        /// </summary>
        /// <param name="Meta">Metadata for query.</param>
        /// <param name="Drugs">Drugs found in query.</param>
        /// <param name="DrugPackages">DrugPackages.</param>

        public DrugSearchResponse(Meta Meta = null, List<Drug> Drugs = null, List<DrugPackage> DrugPackages = null)
        {
            this.Meta = Meta;
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
        /// Drugs found in query
        /// </summary>
        /// <value>Drugs found in query</value>
        [DataMember(Name="drugs", EmitDefaultValue=false)]
        public List<Drug> Drugs { get; set; }
    
        /// <summary>
        /// DrugPackages
        /// </summary>
        /// <value>DrugPackages</value>
        [DataMember(Name="drug_packages", EmitDefaultValue=false)]
        public List<DrugPackage> DrugPackages { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrugSearchResponse {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(obj as DrugSearchResponse);
        }

        /// <summary>
        /// Returns true if DrugSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DrugSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrugSearchResponse other)
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
                if (this.Drugs != null)
                    hash = hash * 59 + this.Drugs.GetHashCode();
                if (this.DrugPackages != null)
                    hash = hash * 59 + this.DrugPackages.GetHashCode();
                return hash;
            }
        }

    }
}
