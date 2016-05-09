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
    public partial class ZipCounty :  IEquatable<ZipCounty>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipCounty" /> class.
        /// Initializes a new instance of the <see cref="ZipCounty" />class.
        /// </summary>
        /// <param name="CountyId">ID of the parent County in Vericred&#39;s API.</param>
        /// <param name="Id">Primary key.</param>
        /// <param name="ZipCodeId">ID of the parent Zip Code in Vericred&#39;s API.</param>

        public ZipCounty(int? CountyId = null, int? Id = null, int? ZipCodeId = null)
        {
            this.CountyId = CountyId;
            this.Id = Id;
            this.ZipCodeId = ZipCodeId;
            
        }

    
        /// <summary>
        /// ID of the parent County in Vericred&#39;s API
        /// </summary>
        /// <value>ID of the parent County in Vericred&#39;s API</value>
        [DataMember(Name="county_id", EmitDefaultValue=false)]
        public int? CountyId { get; set; }
    
        /// <summary>
        /// Primary key
        /// </summary>
        /// <value>Primary key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// ID of the parent Zip Code in Vericred&#39;s API
        /// </summary>
        /// <value>ID of the parent Zip Code in Vericred&#39;s API</value>
        [DataMember(Name="zip_code_id", EmitDefaultValue=false)]
        public int? ZipCodeId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZipCounty {\n");
            sb.Append("  CountyId: ").Append(CountyId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ZipCodeId: ").Append(ZipCodeId).Append("\n");
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
            return this.Equals(obj as ZipCounty);
        }

        /// <summary>
        /// Returns true if ZipCounty instances are equal
        /// </summary>
        /// <param name="other">Instance of ZipCounty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZipCounty other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CountyId == other.CountyId ||
                    this.CountyId != null &&
                    this.CountyId.Equals(other.CountyId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ZipCodeId == other.ZipCodeId ||
                    this.ZipCodeId != null &&
                    this.ZipCodeId.Equals(other.ZipCodeId)
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
                if (this.CountyId != null)
                    hash = hash * 59 + this.CountyId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ZipCodeId != null)
                    hash = hash * 59 + this.ZipCodeId.GetHashCode();
                return hash;
            }
        }

    }
}
