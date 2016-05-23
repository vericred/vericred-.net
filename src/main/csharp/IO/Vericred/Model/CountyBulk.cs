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
    public partial class CountyBulk :  IEquatable<CountyBulk>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CountyBulk" /> class.
        /// Initializes a new instance of the <see cref="CountyBulk" />class.
        /// </summary>
        /// <param name="Id">FIPs code for the county.</param>
        /// <param name="Name">Name of the county.</param>
        /// <param name="StateId">State code.</param>

        public CountyBulk(string Id = null, string Name = null, string StateId = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.StateId = StateId;
            
        }

    
        /// <summary>
        /// FIPs code for the county
        /// </summary>
        /// <value>FIPs code for the county</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Name of the county
        /// </summary>
        /// <value>Name of the county</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// State code
        /// </summary>
        /// <value>State code</value>
        [DataMember(Name="state_id", EmitDefaultValue=false)]
        public string StateId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountyBulk {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as CountyBulk);
        }

        /// <summary>
        /// Returns true if CountyBulk instances are equal
        /// </summary>
        /// <param name="other">Instance of CountyBulk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountyBulk other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.StateId != null)
                    hash = hash * 59 + this.StateId.GetHashCode();
                return hash;
            }
        }

    }
}
