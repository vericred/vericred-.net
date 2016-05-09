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
    public partial class ZipCode :  IEquatable<ZipCode>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipCode" /> class.
        /// Initializes a new instance of the <see cref="ZipCode" />class.
        /// </summary>
        /// <param name="Code">5 digit code (e.g. 11215).</param>
        /// <param name="Id">Primary key.</param>

        public ZipCode(string Code = null, int? Id = null)
        {
            this.Code = Code;
            this.Id = Id;
            
        }

    
        /// <summary>
        /// 5 digit code (e.g. 11215)
        /// </summary>
        /// <value>5 digit code (e.g. 11215)</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
    
        /// <summary>
        /// Primary key
        /// </summary>
        /// <value>Primary key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZipCode {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as ZipCode);
        }

        /// <summary>
        /// Returns true if ZipCode instances are equal
        /// </summary>
        /// <param name="other">Instance of ZipCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZipCode other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

    }
}
