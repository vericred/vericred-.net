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
    public partial class PlanSearchResponse :  IEquatable<PlanSearchResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanSearchResponse" /> class.
        /// Initializes a new instance of the <see cref="PlanSearchResponse" />class.
        /// </summary>
        /// <param name="Meta">Metadata for query.</param>
        /// <param name="Plans">Plan search results.</param>
        /// <param name="Coverages">null.</param>

        public PlanSearchResponse(Meta Meta = null, List<Plan> Plans = null, List<Drug> Coverages = null)
        {
            this.Meta = Meta;
            this.Plans = Plans;
            this.Coverages = Coverages;
            
        }

    
        /// <summary>
        /// Metadata for query
        /// </summary>
        /// <value>Metadata for query</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }
    
        /// <summary>
        /// Plan search results
        /// </summary>
        /// <value>Plan search results</value>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public List<Plan> Plans { get; set; }
    
        /// <summary>
        /// null
        /// </summary>
        /// <value>null</value>
        [DataMember(Name="coverages", EmitDefaultValue=false)]
        public List<Drug> Coverages { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanSearchResponse {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
            sb.Append("  Coverages: ").Append(Coverages).Append("\n");
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
            return this.Equals(obj as PlanSearchResponse);
        }

        /// <summary>
        /// Returns true if PlanSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanSearchResponse other)
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
                    this.Plans == other.Plans ||
                    this.Plans != null &&
                    this.Plans.SequenceEqual(other.Plans)
                ) && 
                (
                    this.Coverages == other.Coverages ||
                    this.Coverages != null &&
                    this.Coverages.SequenceEqual(other.Coverages)
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
                if (this.Plans != null)
                    hash = hash * 59 + this.Plans.GetHashCode();
                if (this.Coverages != null)
                    hash = hash * 59 + this.Coverages.GetHashCode();
                return hash;
            }
        }

    }
}
