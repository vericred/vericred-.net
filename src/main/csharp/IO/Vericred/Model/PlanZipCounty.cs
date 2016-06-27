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
    public partial class PlanZipCounty :  IEquatable<PlanZipCounty>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanZipCounty" /> class.
        /// Initializes a new instance of the <see cref="PlanZipCounty" />class.
        /// </summary>
        /// <param name="PlanId">Foreign key to plan.</param>
        /// <param name="CountyId">Foreign key to county.</param>
        /// <param name="ZipCodeId">Foreign key to zip code.</param>

        public PlanZipCounty(int? PlanId = null, int? CountyId = null, int? ZipCodeId = null)
        {
            this.PlanId = PlanId;
            this.CountyId = CountyId;
            this.ZipCodeId = ZipCodeId;
            
        }

    
        /// <summary>
        /// Foreign key to plan
        /// </summary>
        /// <value>Foreign key to plan</value>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        public int? PlanId { get; set; }
    
        /// <summary>
        /// Foreign key to county
        /// </summary>
        /// <value>Foreign key to county</value>
        [DataMember(Name="county_id", EmitDefaultValue=false)]
        public int? CountyId { get; set; }
    
        /// <summary>
        /// Foreign key to zip code
        /// </summary>
        /// <value>Foreign key to zip code</value>
        [DataMember(Name="zip_code_id", EmitDefaultValue=false)]
        public int? ZipCodeId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanZipCounty {\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  CountyId: ").Append(CountyId).Append("\n");
            sb.Append("  ZipCodeId: ").Append(ZipCodeId).Append("\n");
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
            return this.Equals(obj as PlanZipCounty);
        }

        /// <summary>
        /// Returns true if PlanZipCounty instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanZipCounty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanZipCounty other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.CountyId == other.CountyId ||
                    this.CountyId != null &&
                    this.CountyId.Equals(other.CountyId)
                ) && 
                (
                    this.ZipCodeId == other.ZipCodeId ||
                    this.ZipCodeId != null &&
                    this.ZipCodeId.Equals(other.ZipCodeId)
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
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.CountyId != null)
                    hash = hash * 59 + this.CountyId.GetHashCode();
                if (this.ZipCodeId != null)
                    hash = hash * 59 + this.ZipCodeId.GetHashCode();
                return hash;
            }
        }

    }
}
