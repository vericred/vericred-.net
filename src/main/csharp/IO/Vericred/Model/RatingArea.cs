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
    public partial class RatingArea :  IEquatable<RatingArea>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingArea" /> class.
        /// Initializes a new instance of the <see cref="RatingArea" />class.
        /// </summary>
        /// <param name="Id">Primary key.</param>
        /// <param name="StateId">Foreign key to state.</param>

        public RatingArea(int? Id = null, int? StateId = null)
        {
            this.Id = Id;
            this.StateId = StateId;
            
        }

    
        /// <summary>
        /// Primary key
        /// </summary>
        /// <value>Primary key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Foreign key to state
        /// </summary>
        /// <value>Foreign key to state</value>
        [DataMember(Name="state_id", EmitDefaultValue=false)]
        public int? StateId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RatingArea {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
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
            return this.Equals(obj as RatingArea);
        }

        /// <summary>
        /// Returns true if RatingArea instances are equal
        /// </summary>
        /// <param name="other">Instance of RatingArea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RatingArea other)
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
                    this.StateId == other.StateId ||
                    this.StateId != null &&
                    this.StateId.Equals(other.StateId)
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
                if (this.StateId != null)
                    hash = hash * 59 + this.StateId.GetHashCode();
                return hash;
            }
        }

    }
}
