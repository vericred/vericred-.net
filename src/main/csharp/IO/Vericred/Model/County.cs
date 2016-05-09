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
    public partial class County :  IEquatable<County>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="County" /> class.
        /// Initializes a new instance of the <see cref="County" />class.
        /// </summary>
        /// <param name="Id">Primary key.</param>
        /// <param name="FipsCode">State FIPS code.</param>
        /// <param name="Name">Human-readable name.</param>
        /// <param name="StateCode">Two-character state code.</param>
        /// <param name="StateId">state relationship.</param>
        /// <param name="StateLive">Is the state containing this county active for consumers? *deprecated in favor of last_date_for_individual.</param>
        /// <param name="StateLiveForBusiness">Is the state containing this county active for business? *deprecated in favor of last_date_for_shop.</param>

        public County(int? Id = null, string FipsCode = null, string Name = null, string StateCode = null, int? StateId = null, bool? StateLive = null, bool? StateLiveForBusiness = null)
        {
            this.Id = Id;
            this.FipsCode = FipsCode;
            this.Name = Name;
            this.StateCode = StateCode;
            this.StateId = StateId;
            this.StateLive = StateLive;
            this.StateLiveForBusiness = StateLiveForBusiness;
            
        }

    
        /// <summary>
        /// Primary key
        /// </summary>
        /// <value>Primary key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// State FIPS code
        /// </summary>
        /// <value>State FIPS code</value>
        [DataMember(Name="fips_code", EmitDefaultValue=false)]
        public string FipsCode { get; set; }
    
        /// <summary>
        /// Human-readable name
        /// </summary>
        /// <value>Human-readable name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Two-character state code
        /// </summary>
        /// <value>Two-character state code</value>
        [DataMember(Name="state_code", EmitDefaultValue=false)]
        public string StateCode { get; set; }
    
        /// <summary>
        /// state relationship
        /// </summary>
        /// <value>state relationship</value>
        [DataMember(Name="state_id", EmitDefaultValue=false)]
        public int? StateId { get; set; }
    
        /// <summary>
        /// Is the state containing this county active for consumers? *deprecated in favor of last_date_for_individual
        /// </summary>
        /// <value>Is the state containing this county active for consumers? *deprecated in favor of last_date_for_individual</value>
        [DataMember(Name="state_live", EmitDefaultValue=false)]
        public bool? StateLive { get; set; }
    
        /// <summary>
        /// Is the state containing this county active for business? *deprecated in favor of last_date_for_shop
        /// </summary>
        /// <value>Is the state containing this county active for business? *deprecated in favor of last_date_for_shop</value>
        [DataMember(Name="state_live_for_business", EmitDefaultValue=false)]
        public bool? StateLiveForBusiness { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class County {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FipsCode: ").Append(FipsCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  StateLive: ").Append(StateLive).Append("\n");
            sb.Append("  StateLiveForBusiness: ").Append(StateLiveForBusiness).Append("\n");
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
            return this.Equals(obj as County);
        }

        /// <summary>
        /// Returns true if County instances are equal
        /// </summary>
        /// <param name="other">Instance of County to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(County other)
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
                    this.FipsCode == other.FipsCode ||
                    this.FipsCode != null &&
                    this.FipsCode.Equals(other.FipsCode)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.StateCode == other.StateCode ||
                    this.StateCode != null &&
                    this.StateCode.Equals(other.StateCode)
                ) && 
                (
                    this.StateId == other.StateId ||
                    this.StateId != null &&
                    this.StateId.Equals(other.StateId)
                ) && 
                (
                    this.StateLive == other.StateLive ||
                    this.StateLive != null &&
                    this.StateLive.Equals(other.StateLive)
                ) && 
                (
                    this.StateLiveForBusiness == other.StateLiveForBusiness ||
                    this.StateLiveForBusiness != null &&
                    this.StateLiveForBusiness.Equals(other.StateLiveForBusiness)
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
                if (this.FipsCode != null)
                    hash = hash * 59 + this.FipsCode.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.StateCode != null)
                    hash = hash * 59 + this.StateCode.GetHashCode();
                if (this.StateId != null)
                    hash = hash * 59 + this.StateId.GetHashCode();
                if (this.StateLive != null)
                    hash = hash * 59 + this.StateLive.GetHashCode();
                if (this.StateLiveForBusiness != null)
                    hash = hash * 59 + this.StateLiveForBusiness.GetHashCode();
                return hash;
            }
        }

    }
}
