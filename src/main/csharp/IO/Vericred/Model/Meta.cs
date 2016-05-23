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
    public partial class Meta :  IEquatable<Meta>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// Initializes a new instance of the <see cref="Meta" />class.
        /// </summary>
        /// <param name="Total">Number of entities returned.</param>

        public Meta(int? Total = null)
        {
            this.Total = Total;
            
        }

    
        /// <summary>
        /// Number of entities returned
        /// </summary>
        /// <value>Number of entities returned</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Meta {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(obj as Meta);
        }

        /// <summary>
        /// Returns true if Meta instances are equal
        /// </summary>
        /// <param name="other">Instance of Meta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Meta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                return hash;
            }
        }

    }
}
