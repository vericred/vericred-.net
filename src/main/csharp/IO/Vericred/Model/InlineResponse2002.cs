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
    public partial class InlineResponse2002 :  IEquatable<InlineResponse2002>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002" /> class.
        /// Initializes a new instance of the <see cref="InlineResponse2002" />class.
        /// </summary>
        /// <param name="ZipCounties">ZipCounties.</param>
        /// <param name="Counties">Counties.</param>
        /// <param name="ZipCodes">ZipCodes.</param>

        public InlineResponse2002(List<ZipCounty> ZipCounties = null, List<County> Counties = null, List<ZipCode> ZipCodes = null)
        {
            this.ZipCounties = ZipCounties;
            this.Counties = Counties;
            this.ZipCodes = ZipCodes;
            
        }

    
        /// <summary>
        /// Gets or Sets ZipCounties
        /// </summary>
        [DataMember(Name="zip_counties", EmitDefaultValue=false)]
        public List<ZipCounty> ZipCounties { get; set; }
    
        /// <summary>
        /// Gets or Sets Counties
        /// </summary>
        [DataMember(Name="counties", EmitDefaultValue=false)]
        public List<County> Counties { get; set; }
    
        /// <summary>
        /// Gets or Sets ZipCodes
        /// </summary>
        [DataMember(Name="zip_codes", EmitDefaultValue=false)]
        public List<ZipCode> ZipCodes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2002 {\n");
            sb.Append("  ZipCounties: ").Append(ZipCounties).Append("\n");
            sb.Append("  Counties: ").Append(Counties).Append("\n");
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
            return this.Equals(obj as InlineResponse2002);
        }

        /// <summary>
        /// Returns true if InlineResponse2002 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2002 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2002 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ZipCounties == other.ZipCounties ||
                    this.ZipCounties != null &&
                    this.ZipCounties.SequenceEqual(other.ZipCounties)
                ) && 
                (
                    this.Counties == other.Counties ||
                    this.Counties != null &&
                    this.Counties.SequenceEqual(other.Counties)
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
                if (this.ZipCounties != null)
                    hash = hash * 59 + this.ZipCounties.GetHashCode();
                if (this.Counties != null)
                    hash = hash * 59 + this.Counties.GetHashCode();
                if (this.ZipCodes != null)
                    hash = hash * 59 + this.ZipCodes.GetHashCode();
                return hash;
            }
        }

    }
}
