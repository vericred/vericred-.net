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
    public partial class ZipCountyResponse :  IEquatable<ZipCountyResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipCountyResponse" /> class.
        /// Initializes a new instance of the <see cref="ZipCountyResponse" />class.
        /// </summary>
        /// <param name="Counties">Counties that exist in the provided zip prefix..</param>
        /// <param name="States">States that exist in the provided zip prefix..</param>
        /// <param name="ZipCodes">ZipCodes that exist in the provided zip prefix..</param>
        /// <param name="ZipCounty">ZipCounty data.</param>

        public ZipCountyResponse(List<County> Counties = null, List<State> States = null, List<ZipCode> ZipCodes = null, ZipCounty ZipCounty = null)
        {
            this.Counties = Counties;
            this.States = States;
            this.ZipCodes = ZipCodes;
            this.ZipCounty = ZipCounty;
            
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
        /// ZipCodes that exist in the provided zip prefix.
        /// </summary>
        /// <value>ZipCodes that exist in the provided zip prefix.</value>
        [DataMember(Name="zip_codes", EmitDefaultValue=false)]
        public List<ZipCode> ZipCodes { get; set; }
    
        /// <summary>
        /// ZipCounty data
        /// </summary>
        /// <value>ZipCounty data</value>
        [DataMember(Name="zip_county", EmitDefaultValue=false)]
        public ZipCounty ZipCounty { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZipCountyResponse {\n");
            sb.Append("  Counties: ").Append(Counties).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  ZipCodes: ").Append(ZipCodes).Append("\n");
            sb.Append("  ZipCounty: ").Append(ZipCounty).Append("\n");
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
            return this.Equals(obj as ZipCountyResponse);
        }

        /// <summary>
        /// Returns true if ZipCountyResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ZipCountyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZipCountyResponse other)
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
                    this.ZipCodes == other.ZipCodes ||
                    this.ZipCodes != null &&
                    this.ZipCodes.SequenceEqual(other.ZipCodes)
                ) && 
                (
                    this.ZipCounty == other.ZipCounty ||
                    this.ZipCounty != null &&
                    this.ZipCounty.Equals(other.ZipCounty)
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
                if (this.ZipCodes != null)
                    hash = hash * 59 + this.ZipCodes.GetHashCode();
                if (this.ZipCounty != null)
                    hash = hash * 59 + this.ZipCounty.GetHashCode();
                return hash;
            }
        }

    }
}
