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
    public partial class Drug :  IEquatable<Drug>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Drug" /> class.
        /// Initializes a new instance of the <see cref="Drug" />class.
        /// </summary>
        /// <param name="Ndc">National Drug Code ID.</param>
        /// <param name="ProprietaryName">Proprietary name of drug.</param>
        /// <param name="NonProprietaryName">Non-proprietary name of drug.</param>

        public Drug(string Ndc = null, string ProprietaryName = null, string NonProprietaryName = null)
        {
            this.Ndc = Ndc;
            this.ProprietaryName = ProprietaryName;
            this.NonProprietaryName = NonProprietaryName;
            
        }

    
        /// <summary>
        /// National Drug Code ID
        /// </summary>
        /// <value>National Drug Code ID</value>
        [DataMember(Name="ndc", EmitDefaultValue=false)]
        public string Ndc { get; set; }
    
        /// <summary>
        /// Proprietary name of drug
        /// </summary>
        /// <value>Proprietary name of drug</value>
        [DataMember(Name="proprietary_name", EmitDefaultValue=false)]
        public string ProprietaryName { get; set; }
    
        /// <summary>
        /// Non-proprietary name of drug
        /// </summary>
        /// <value>Non-proprietary name of drug</value>
        [DataMember(Name="non_proprietary_name", EmitDefaultValue=false)]
        public string NonProprietaryName { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Drug {\n");
            sb.Append("  Ndc: ").Append(Ndc).Append("\n");
            sb.Append("  ProprietaryName: ").Append(ProprietaryName).Append("\n");
            sb.Append("  NonProprietaryName: ").Append(NonProprietaryName).Append("\n");
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
            return this.Equals(obj as Drug);
        }

        /// <summary>
        /// Returns true if Drug instances are equal
        /// </summary>
        /// <param name="other">Instance of Drug to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Drug other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ndc == other.Ndc ||
                    this.Ndc != null &&
                    this.Ndc.Equals(other.Ndc)
                ) && 
                (
                    this.ProprietaryName == other.ProprietaryName ||
                    this.ProprietaryName != null &&
                    this.ProprietaryName.Equals(other.ProprietaryName)
                ) && 
                (
                    this.NonProprietaryName == other.NonProprietaryName ||
                    this.NonProprietaryName != null &&
                    this.NonProprietaryName.Equals(other.NonProprietaryName)
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
                if (this.Ndc != null)
                    hash = hash * 59 + this.Ndc.GetHashCode();
                if (this.ProprietaryName != null)
                    hash = hash * 59 + this.ProprietaryName.GetHashCode();
                if (this.NonProprietaryName != null)
                    hash = hash * 59 + this.NonProprietaryName.GetHashCode();
                return hash;
            }
        }

    }
}
