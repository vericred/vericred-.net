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
    public partial class ZipCountyBulk :  IEquatable<ZipCountyBulk>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipCountyBulk" /> class.
        /// Initializes a new instance of the <see cref="ZipCountyBulk" />class.
        /// </summary>
        /// <param name="Id">Primary key.</param>
        /// <param name="RatingAreaId">Foreign key for rating area.</param>
        /// <param name="CountyId">Foreign key for county (fips code).</param>
        /// <param name="ZipCodeId">Foreign key for zip code (zip code).</param>

        public ZipCountyBulk(int? Id = null, string RatingAreaId = null, string CountyId = null, string ZipCodeId = null)
        {
            this.Id = Id;
            this.RatingAreaId = RatingAreaId;
            this.CountyId = CountyId;
            this.ZipCodeId = ZipCodeId;
            
        }

    
        /// <summary>
        /// Primary key
        /// </summary>
        /// <value>Primary key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Foreign key for rating area
        /// </summary>
        /// <value>Foreign key for rating area</value>
        [DataMember(Name="rating_area_id", EmitDefaultValue=false)]
        public string RatingAreaId { get; set; }
    
        /// <summary>
        /// Foreign key for county (fips code)
        /// </summary>
        /// <value>Foreign key for county (fips code)</value>
        [DataMember(Name="county_id", EmitDefaultValue=false)]
        public string CountyId { get; set; }
    
        /// <summary>
        /// Foreign key for zip code (zip code)
        /// </summary>
        /// <value>Foreign key for zip code (zip code)</value>
        [DataMember(Name="zip_code_id", EmitDefaultValue=false)]
        public string ZipCodeId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZipCountyBulk {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RatingAreaId: ").Append(RatingAreaId).Append("\n");
            sb.Append("  CountyId: ").Append(CountyId).Append("\n");
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
            return this.Equals(obj as ZipCountyBulk);
        }

        /// <summary>
        /// Returns true if ZipCountyBulk instances are equal
        /// </summary>
        /// <param name="other">Instance of ZipCountyBulk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZipCountyBulk other)
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
                    this.RatingAreaId == other.RatingAreaId ||
                    this.RatingAreaId != null &&
                    this.RatingAreaId.Equals(other.RatingAreaId)
                ) && 
                (
                    this.CountyId == other.CountyId ||
                    this.CountyId != null &&
                    this.CountyId.Equals(other.CountyId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.RatingAreaId != null)
                    hash = hash * 59 + this.RatingAreaId.GetHashCode();
                if (this.CountyId != null)
                    hash = hash * 59 + this.CountyId.GetHashCode();
                if (this.ZipCodeId != null)
                    hash = hash * 59 + this.ZipCodeId.GetHashCode();
                return hash;
            }
        }

    }
}
