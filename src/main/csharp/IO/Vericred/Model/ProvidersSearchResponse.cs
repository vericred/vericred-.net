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
    public partial class ProvidersSearchResponse :  IEquatable<ProvidersSearchResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersSearchResponse" /> class.
        /// Initializes a new instance of the <see cref="ProvidersSearchResponse" />class.
        /// </summary>
        /// <param name="Meta">Meta-data about the response..</param>
        /// <param name="Providers">Providers that fit the requested criterion..</param>
        /// <param name="States">States that fit the requested criterion..</param>

        public ProvidersSearchResponse(Meta Meta = null, List<Provider> Providers = null, List<State> States = null)
        {
            this.Meta = Meta;
            this.Providers = Providers;
            this.States = States;
            
        }

    
        /// <summary>
        /// Meta-data about the response.
        /// </summary>
        /// <value>Meta-data about the response.</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }
    
        /// <summary>
        /// Providers that fit the requested criterion.
        /// </summary>
        /// <value>Providers that fit the requested criterion.</value>
        [DataMember(Name="providers", EmitDefaultValue=false)]
        public List<Provider> Providers { get; set; }
    
        /// <summary>
        /// States that fit the requested criterion.
        /// </summary>
        /// <value>States that fit the requested criterion.</value>
        [DataMember(Name="states", EmitDefaultValue=false)]
        public List<State> States { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvidersSearchResponse {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
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
            return this.Equals(obj as ProvidersSearchResponse);
        }

        /// <summary>
        /// Returns true if ProvidersSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProvidersSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProvidersSearchResponse other)
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
                    this.Providers == other.Providers ||
                    this.Providers != null &&
                    this.Providers.SequenceEqual(other.Providers)
                ) && 
                (
                    this.States == other.States ||
                    this.States != null &&
                    this.States.SequenceEqual(other.States)
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
                if (this.Providers != null)
                    hash = hash * 59 + this.Providers.GetHashCode();
                if (this.States != null)
                    hash = hash * 59 + this.States.GetHashCode();
                return hash;
            }
        }

    }
}
