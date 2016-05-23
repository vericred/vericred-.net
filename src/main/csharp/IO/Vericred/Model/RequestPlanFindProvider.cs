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
    public partial class RequestPlanFindProvider :  IEquatable<RequestPlanFindProvider>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPlanFindProvider" /> class.
        /// Initializes a new instance of the <see cref="RequestPlanFindProvider" />class.
        /// </summary>
        /// <param name="Npi">NPI of provider to search for.</param>

        public RequestPlanFindProvider(int? Npi = null)
        {
            this.Npi = Npi;
            
        }

    
        /// <summary>
        /// NPI of provider to search for
        /// </summary>
        /// <value>NPI of provider to search for</value>
        [DataMember(Name="npi", EmitDefaultValue=false)]
        public int? Npi { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestPlanFindProvider {\n");
            sb.Append("  Npi: ").Append(Npi).Append("\n");
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
            return this.Equals(obj as RequestPlanFindProvider);
        }

        /// <summary>
        /// Returns true if RequestPlanFindProvider instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestPlanFindProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestPlanFindProvider other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Npi == other.Npi ||
                    this.Npi != null &&
                    this.Npi.Equals(other.Npi)
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
                if (this.Npi != null)
                    hash = hash * 59 + this.Npi.GetHashCode();
                return hash;
            }
        }

    }
}
