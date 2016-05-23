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
    public partial class ZipCountiesResponse :  IEquatable<ZipCountiesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipCountiesResponse" /> class.
        /// Initializes a new instance of the <see cref="ZipCountiesResponse" />class.
        /// </summary>
        /// <param name="Counties">Counties that exist in the provided zip prefix..</param>
        /// <param name="States">States that exist in the provided zip prefix..</param>
        /// <param name="ZipCounties">ZipCounties that exist in the provided zip prefix..</param>
        /// <param name="ZipCodes">ZipCodes that exist in the provided zip prefix..</param>

        public ZipCountiesResponse(List<County> Counties = null, List<State> States = null, List<ZipCounty> ZipCounties = null, List<ZipCode> ZipCodes = null)
        {
            this.Counties = Counties;
            this.States = States;
            this.ZipCounties = ZipCounties;
            this.ZipCodes = ZipCodes;
            
        }

    
        /// <summary>
        /// Counties that exist in the provided zip prefix.
        /// </summary>
        /// <value>Counties that exist in the provided zip prefix.</value>
        [DataMember(Name="counties", EmitDefaultValue=false)]
        public List<County> Counties { get; set; }
    
        /// <summary>
        /// States that exist in the provided zip prefix.
        /// </summary>
        /// <value>States that exist in the provided zip prefix.</value>
        [DataMember(Name="states", EmitDefaultValue=false)]
        public List<State> States { get; set; }
    
        /// <summary>
        /// ZipCounties that exist in the provided zip prefix.
        /// </summary>
        /// <value>ZipCounties that exist in the provided zip prefix.</value>
        [DataMember(Name="zip_counties", EmitDefaultValue=false)]
        public List<ZipCounty> ZipCounties { get; set; }
    
        /// <summary>
        /// ZipCodes that exist in the provided zip prefix.
        /// </summary>
        /// <value>ZipCodes that exist in the provided zip prefix.</value>
        [DataMember(Name="zip_codes", EmitDefaultValue=false)]
        public List<ZipCode> ZipCodes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZipCountiesResponse {\n");
            sb.Append("  Counties: ").Append(Counties).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  ZipCounties: ").Append(ZipCounties).Append("\n");
            sb.Append("  ZipCodes: ").Append(ZipCodes).Append("\n");
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
            return this.Equals(obj as ZipCountiesResponse);
        }

        /// <summary>
        /// Returns true if ZipCountiesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ZipCountiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZipCountiesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Counties == other.Counties ||
                    this.Counties != null &&
                    this.Counties.SequenceEqual(other.Counties)
                ) && 
                (
                    this.States == other.States ||
                    this.States != null &&
                    this.States.SequenceEqual(other.States)
                ) && 
                (
                    this.ZipCounties == other.ZipCounties ||
                    this.ZipCounties != null &&
                    this.ZipCounties.SequenceEqual(other.ZipCounties)
                ) && 
                (
                    this.ZipCodes == other.ZipCodes ||
                    this.ZipCodes != null &&
                    this.ZipCodes.SequenceEqual(other.ZipCodes)
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
                if (this.Counties != null)
                    hash = hash * 59 + this.Counties.GetHashCode();
                if (this.States != null)
                    hash = hash * 59 + this.States.GetHashCode();
                if (this.ZipCounties != null)
                    hash = hash * 59 + this.ZipCounties.GetHashCode();
                if (this.ZipCodes != null)
                    hash = hash * 59 + this.ZipCodes.GetHashCode();
                return hash;
            }
        }

    }
}
