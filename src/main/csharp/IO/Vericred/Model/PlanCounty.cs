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
    public partial class PlanCounty :  IEquatable<PlanCounty>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanCounty" /> class.
        /// Initializes a new instance of the <see cref="PlanCounty" />class.
        /// </summary>
        /// <param name="Id">Primary key.</param>
        /// <param name="PlanId">Foreign key to plan.</param>
        /// <param name="CountyId">Foreign key to county.</param>

        public PlanCounty(int? Id = null, int? PlanId = null, int? CountyId = null)
        {
            this.Id = Id;
            this.PlanId = PlanId;
            this.CountyId = CountyId;
            
        }

    
        /// <summary>
        /// Primary key
        /// </summary>
        /// <value>Primary key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanCounty {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  CountyId: ").Append(CountyId).Append("\n");
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
            return this.Equals(obj as PlanCounty);
        }

        /// <summary>
        /// Returns true if PlanCounty instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanCounty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanCounty other)
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
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.CountyId == other.CountyId ||
                    this.CountyId != null &&
                    this.CountyId.Equals(other.CountyId)
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
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.CountyId != null)
                    hash = hash * 59 + this.CountyId.GetHashCode();
                return hash;
            }
        }

    }
}
