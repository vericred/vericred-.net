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
    public partial class CarrierSubsidiary :  IEquatable<CarrierSubsidiary>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierSubsidiary" /> class.
        /// Initializes a new instance of the <see cref="CarrierSubsidiary" />class.
        /// </summary>
        /// <param name="Id">Primary key.</param>
        /// <param name="Name">Subsidiary name.</param>
        /// <param name="AlternateName">Parent Carrier Name.</param>

        public CarrierSubsidiary(int? Id = null, string Name = null, string AlternateName = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.AlternateName = AlternateName;
            
        }

    
        /// <summary>
        /// Primary key
        /// </summary>
        /// <value>Primary key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Subsidiary name
        /// </summary>
        /// <value>Subsidiary name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Parent Carrier Name
        /// </summary>
        /// <value>Parent Carrier Name</value>
        [DataMember(Name="alternate_name", EmitDefaultValue=false)]
        public string AlternateName { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CarrierSubsidiary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AlternateName: ").Append(AlternateName).Append("\n");
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
            return this.Equals(obj as CarrierSubsidiary);
        }

        /// <summary>
        /// Returns true if CarrierSubsidiary instances are equal
        /// </summary>
        /// <param name="other">Instance of CarrierSubsidiary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarrierSubsidiary other)
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
                    this.AlternateName == other.AlternateName ||
                    this.AlternateName != null &&
                    this.AlternateName.Equals(other.AlternateName)
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
                if (this.AlternateName != null)
                    hash = hash * 59 + this.AlternateName.GetHashCode();
                return hash;
            }
        }

    }
}
