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
    public partial class NetworkSearchResponse :  IEquatable<NetworkSearchResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkSearchResponse" /> class.
        /// Initializes a new instance of the <see cref="NetworkSearchResponse" />class.
        /// </summary>
        /// <param name="Meta">Metadata for query.</param>
        /// <param name="Networks">Networks that fit the requested criterion..</param>

        public NetworkSearchResponse(Meta Meta = null, List<Network> Networks = null)
        {
            this.Meta = Meta;
            this.Networks = Networks;
            
        }

    
        /// <summary>
        /// Metadata for query
        /// </summary>
        /// <value>Metadata for query</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }
    
        /// <summary>
        /// Networks that fit the requested criterion.
        /// </summary>
        /// <value>Networks that fit the requested criterion.</value>
        [DataMember(Name="networks", EmitDefaultValue=false)]
        public List<Network> Networks { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkSearchResponse {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Networks: ").Append(Networks).Append("\n");
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
            return this.Equals(obj as NetworkSearchResponse);
        }

        /// <summary>
        /// Returns true if NetworkSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
                ) && 
                (
                    this.Networks == other.Networks ||
                    this.Networks != null &&
                    this.Networks.SequenceEqual(other.Networks)
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
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                if (this.Networks != null)
                    hash = hash * 59 + this.Networks.GetHashCode();
                return hash;
            }
        }

    }
}
