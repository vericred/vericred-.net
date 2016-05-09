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
    public partial class InlineResponse2001 :  IEquatable<InlineResponse2001>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001" /> class.
        /// Initializes a new instance of the <see cref="InlineResponse2001" />class.
        /// </summary>
        /// <param name="Provider">Provider.</param>

        public InlineResponse2001(Provider Provider = null)
        {
            this.Provider = Provider;
            
        }

    
        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public Provider Provider { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001 {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
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
            return this.Equals(obj as InlineResponse2001);
        }

        /// <summary>
        /// Returns true if InlineResponse2001 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2001 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2001 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
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
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                return hash;
            }
        }

    }
}
